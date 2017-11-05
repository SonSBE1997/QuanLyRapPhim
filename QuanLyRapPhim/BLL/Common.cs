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
        public void DuyetComboBox(ComboBox c, string key)
        {
            foreach (string item in c.Items)
            {
                if (key == item)
                {
                    c.SelectedItem = item;
                    return;
                }
            }
        }

        public void KeyPressEvent(KeyPressEventArgs e, string mess)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                MessageBox.Show(mess);
                e.Handled = true;
            }
        }

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
            for (int i = 0; i < table.Rows.Count; i++)
            {

                int d = 0;
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if (table.Rows[i][j].ToString().Contains(key))
                    {
                        d++;
                    }
                }
                if (d == 0) { table.Rows.RemoveAt(i); i--; }
            }
            return table;
        }
    }
}
