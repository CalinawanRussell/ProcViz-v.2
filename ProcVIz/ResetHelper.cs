using ProcViz;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProcVIz
{
    internal static class ResetHelper
    {
        public static void ResetScheduler(
            DataGridView dgv,
            Panel ganttPanel,
            TextBox[] inputs,
            List<GanttBlock> ganttData)
        {

            dgv.Rows.Clear();


            ganttData.Clear();


            foreach (var txt in inputs)
                txt.Clear();

            ganttPanel.Invalidate();
        }
    }
}