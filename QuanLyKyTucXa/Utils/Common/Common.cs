using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Utils.Common
{
    class Common
    {
        // Get DataTable
        public static DataTable GetDataTable(params string[] labels)
        {
            DataTable dt = new DataTable();
            foreach (var label in labels)
            {
                dt.Columns.Add(label, typeof(string));
            }
            return dt;
        }

        // Get Value Of Cell
        public static string GetValueOfCellGridView
        (
            DataGridView dgv,
            int RowIndex,
            int CellIndex
        )
        {
            return dgv.
                Rows[RowIndex].Cells[CellIndex].
                Value.ToString().Trim();
        }

        public static string GetFormatValueOfCellGridView
        (
            DataGridView dgv,
            int RowIndex,
            int CellIndex
        )
        {
            return dgv.
                Rows[RowIndex].Cells[CellIndex].FormattedValue.ToString();
        }

        // Get Value TextBox
        public static string GetValueTextBox(TextBox tb)
        {
            return tb.Text.Trim();
        }

        // Get Value ComboBox
        public static string GetValueComboBox(ComboBox cb)
        {
            if(cb.SelectedValue != null)
                return cb.SelectedValue.ToString().Trim();
            return null;
        }

        public static void ShowForm(dynamic currentForm, dynamic nextForm)
        {
            currentForm.Hide();
            nextForm.ShowDialog();
            currentForm.Close();
        }

        // Set Width Of Cell DataGridView
        public static void SetWidthOfCell
        (
            DataGridView dgv,
            int[] widths
        )
        {
            for (int i = 0; i < widths.Length; i++)
            {
                dgv.Columns[i].Width = widths[i];
            }
        }

        // Get Value DT box
        public static DateTime GetValueDateTimePicker(DateTimePicker cb)
        {
            DateTime dt = cb.Value.Date;
            return dt;
        }

        // Get Current Row Selected
        public static int GetCurrentRowSelected(DataGridView dgv)
        {
            try
            {
                if (dgv.CurrentCell != null)
                {
                    int rowIndex = dgv.CurrentCell.RowIndex;
                    return rowIndex;
                }
                return -1;
            }
            catch
            {
                return -1;
            }

        }
    }
}
