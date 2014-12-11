using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDBase
{
    public partial class ManageCollection : Form
    {
        private FormMain _parent;

        public ManageCollection(FormMain parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void updateGridView()
        {
            List<A_Component> list = _parent.Items;
            dataGridViewRemoveList.Rows.Clear();

            foreach (A_Component item in list)
                dataGridViewRemoveList.Rows.Add(item.Name);

            _parent.updateGridView();
        }

        private void tabRemove_Enter(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Note: Descern item to add here later
            addItem(new Game(textBoxNameAdd.Text, textBoxSystemAdd.Text,
                Convert.ToInt32(textBoxYearAdd.Text)));
        }

        private void addItem(A_Component item)
        {
            List<A_Component> list = _parent.Items;
            
            list.Add(item);
            updateGridView();
        }

        private void removeItem(A_Component item)
        {
            List<A_Component> list = _parent.Items;
            
            list.Remove(item);
            updateGridView();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Focus();
            this.Dispose();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            List<A_Component> list = _parent.Items;
            List<A_Component> removalList = _parent.Removals;
            List<A_Component> tempRemovals = new List<A_Component>();
            string removal;

            foreach (DataGridViewRow row in dataGridViewRemoveList.SelectedRows)
            {
                removal = row.Cells[0].Value.ToString();
                
                foreach(A_Component item in list)
                    if (removal.Equals(item.Name))
                    {
                        tempRemovals.Add(item);
                        break;
                    }
            }

            foreach (A_Component item in tempRemovals)
                removeItem(item);

            removalList.AddRange(tempRemovals);
        }
        
    }
}
