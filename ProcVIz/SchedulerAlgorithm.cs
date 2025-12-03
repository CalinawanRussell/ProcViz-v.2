using System;
using System.Collections.Generic;
using System.Linq;

namespace ProcVIz
{
    public static class SchedulerAlgorithms
    {
        private class ProcState
        {
            public string PID { get; set; }
            public int AT { get; set; }
            public int BT { get; set; }
            public int Remaining { get; set; }
            public int CT { get; set; }
        }

        private class ProcStatePriority
        {
            public string PID { get; set; }
            public int AT { get; set; }
            public int BT { get; set; }
            public int Priority { get; set; }
            public int Remaining { get; set; }
            public int CT { get; set; }
        }

        public static SchedulerResult RunFCFS(List<ProcessModel> processes)
        {
            if (processes == null || processes.Count == 0)
                throw new InvalidOperationException("No processes provided.");

            var procs = processes.OrderBy(p => p.AT).ToList();

            int time = 0, totalWT = 0, totalTAT = 0;

            foreach (var p in procs)
            {
                if (time < p.AT) time = p.AT;
                int ct = time + p.BT;
                int tat = ct - p.AT;
                int wt = tat - p.BT;

                totalWT += wt;
                totalTAT += tat;
                time = ct;
            }

            return new SchedulerResult
            {
                AvgWaiting = (double)totalWT / procs.Count,
                AvgTurnaround = (double)totalTAT / procs.Count,
                Throughput = time > 0 ? (double)procs.Count / time : 0
            };
        }

        public static SchedulerResult RunSJF(List<ProcessModel> processes)
        {
            if (processes == null || processes.Count == 0)
                throw new InvalidOperationException("No processes provided.");

            var procs = processes.OrderBy(p => p.AT).ToList();
            int time = procs.Min(p => p.AT);
            int completed = 0, totalWT = 0, totalTAT = 0;
            var done = new HashSet<string>();

            while (completed < procs.Count)
            {
                var available = procs
                    .Where(p => !done.Contains(p.PID) && p.AT <= time)
                    .OrderBy(p => p.BT)
                    .ThenBy(p => p.AT)
                    .ToList();

                if (available.Count == 0) { time++; continue; }

                var proc = available.First();
                int ct = time + proc.BT;
                int tat = ct - proc.AT;
                int wt = tat - proc.BT;

                totalWT += wt;
                totalTAT += tat;

                time = ct;
                done.Add(proc.PID);
                completed++;
            }

            return new SchedulerResult
            {
                AvgWaiting = (double)totalWT / procs.Count,
                AvgTurnaround = (double)totalTAT / procs.Count,
                Throughput = time > 0 ? (double)procs.Count / time : 0
            };
        }
        public static SchedulerResult RunRR(List<ProcessModel> processes, int quantum)
        {
            if (processes == null || processes.Count == 0)
                throw new InvalidOperationException("No processes provided.");
            if (quantum <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantum), "Quantum must be positive.");

            var procs = processes
                .Select(p => new ProcState
                {
                    PID = p.PID,
                    AT = p.AT,
                    BT = p.BT,
                    Remaining = p.BT,
                    CT = 0
                })
                .OrderBy(p => p.AT)
                .ToList();

            int time = procs.Min(p => p.AT);
            int completed = 0, totalWT = 0, totalTAT = 0;
            var readyQueue = new Queue<ProcState>();
            var enqueued = new HashSet<string>();

            while (completed < procs.Count)
            {
                foreach (var p in procs.Where(p => p.AT <= time && p.Remaining > 0 && !enqueued.Contains(p.PID)))
                {
                    readyQueue.Enqueue(p);
                    enqueued.Add(p.PID);
                }

                if (readyQueue.Count == 0) { time++; continue; }

                var proc = readyQueue.Dequeue();
                int slice = Math.Min(proc.Remaining, quantum);

                proc.Remaining -= slice;
                time += slice;

                foreach (var p in procs.Where(p => p.AT <= time && p.Remaining > 0 && !enqueued.Contains(p.PID)))
                {
                    readyQueue.Enqueue(p);
                    enqueued.Add(p.PID);
                }

                if (proc.Remaining > 0)
                {
                    readyQueue.Enqueue(proc);
                }
                else
                {
                    proc.CT = time;
                    completed++;

                    int tat = proc.CT - proc.AT;
                    int wt = tat - proc.BT;

                    totalWT += wt;
                    totalTAT += tat;
                }
            }

            return new SchedulerResult
            {
                AvgWaiting = (double)totalWT / procs.Count,
                AvgTurnaround = (double)totalTAT / procs.Count,
                Throughput = time > 0 ? (double)procs.Count / time : 0
            };
        }
        public static SchedulerResult RunPNP(List<ProcessModel> processes)
        {
            if (processes == null || processes.Count == 0)
                throw new InvalidOperationException("No processes provided.");

            var procs = processes
                .Select(p => new ProcStatePriority
                {
                    PID = p.PID,
                    AT = p.AT,
                    BT = p.BT,
                    Priority = p.Priority,
                    Remaining = p.BT,
                    CT = 0
                })
                .OrderBy(p => p.AT)
                .ToList();

            int time = procs.Min(p => p.AT);
            int completed = 0, totalWT = 0, totalTAT = 0;

            while (completed < procs.Count)
            {
                var available = procs
                    .Where(p => p.Remaining > 0 && p.AT <= time)
                    .OrderBy(p => p.Priority)
                    .ThenBy(p => p.AT)
                    .ToList();

                if (available.Count == 0) { time++; continue; }

                var proc = available.First();
                proc.Remaining--;
                time++;

                if (proc.Remaining == 0)
                {
                    proc.CT = time;
                    completed++;

                    int tat = proc.CT - proc.AT;
                    int wt = tat - proc.BT;

                    totalWT += wt;
                    totalTAT += tat;
                }
            }

            return new SchedulerResult
            {
                AvgWaiting = (double)totalWT / procs.Count,
                AvgTurnaround = (double)totalTAT / procs.Count,
                Throughput = time > 0 ? (double)procs.Count / time : 0
            };
        }
    }
}