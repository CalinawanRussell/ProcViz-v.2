using System;
using System.Windows.Forms;

namespace ProcVIz
{
    public class BaseSchedulerForm : Form
    {
        protected DataGridView dgvProcesses;
        protected Panel ganttPanel;

        protected virtual void RemoveFromGantt(string processName) { }
        protected virtual void ClearGanttData() { }

        protected void HookDeleteButton(Button deleteButton, DataGridView dgv, Panel gantt)
        {
            dgvProcesses = dgv;
            ganttPanel = gantt;

            deleteButton.Click += (s, e) =>
            {
                if (dgvProcesses.CurrentRow == null || dgvProcesses.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Please select a valid process row to delete.");
                    return;
                }

                string processName = dgvProcesses.CurrentRow.Cells["Process"].Value?.ToString();

                var confirm = MessageBox.Show(
                    $"Delete process \"{processName}\"?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    dgvProcesses.Rows.Remove(dgvProcesses.CurrentRow);
                    RemoveFromGantt(processName);
                    ganttPanel?.Invalidate();
                }
            };
        }

        protected void HookClearAllButton(Button clearButton, DataGridView dgv, Panel gantt)
        {
            dgvProcesses = dgv;
            ganttPanel = gantt;

            clearButton.Click += (s, e) =>
            {
                var confirm = MessageBox.Show(
                    "Clear all processes?",
                    "Confirm Clear",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    dgvProcesses.Rows.Clear();
                    ClearGanttData();
                    ganttPanel?.Invalidate();
                }
            };
        }
    }
}