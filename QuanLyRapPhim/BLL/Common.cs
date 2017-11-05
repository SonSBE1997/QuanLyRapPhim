using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.BLL
{
    public class Common
    {
        public void Previous(DataGridView view)
        {
            int index = view.CurrentRow.Index;
            if (index > 0)
            {
                view.CurrentCell = view[0, index - 1];
            }
            else MessageBox.Show("Đây đã là bản ghi đầu tiên.");
        }

        public void Next(DataGridView view)
        {
            int index = view.CurrentRow.Index;
            int max = view.Rows.Count;
            if (index < (max - 1))
                view.CurrentCell = view[0, index + 1];
            else MessageBox.Show("Đây đã là bản ghi cuối cùng");
        }

        public void First(DataGridView view)
        {
            view.CurrentCell = view[0, 0];
        }

        public void Last(DataGridView view)
        {
            view.CurrentCell = view[0, view.Rows.Count - 1];
        }

        public DataTable TimKiem(DataTable table, string key)
        {
            int row = table.Rows.Count;
            if (row == 0) return null;
            int col = table.Columns.Count;
            for (int i = 0; i < row; i++)
            {
                int d = 0;
                for (int j = 0; j < col; j++)
                {
                    if (table.Rows[i][j].ToString().Contains(key))
                    {
                        d++;
                    }
                }
                if (d == 0) table.Rows.RemoveAt(i);
            }
            return table;
        }
    }
}
