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
    public partial class FormMain : Form
    {
        private DatabaseManager _database;
        private List<A_Component> _itemRemovals;
        private List<A_Component> _itemList;
        
        public FormMain()
        {
            InitializeComponent();
            comboBoxSystem.SelectedIndex = 0;
            _database = new DatabaseManager();
            _itemList = new List<A_Component>();
            _itemRemovals = new List<A_Component>();

            _itemList.AddRange(loadStoredItems());
            updateGridView();
        }

        public List<A_Component> Items
        {
            get { return _itemList; }    
        }

        public List<A_Component> Removals
        {
            get { return _itemRemovals; }
        }

        public void updateGridView()
        {
            dataGridViewItems.Rows.Clear();
            foreach (A_Component item in _itemList)
                dataGridViewItems.Rows.Add(item.Name, item.System, item.Year);
        }

        private void buttonManageCollection_Click(object sender, EventArgs e)
        {
            ManageCollection manageCollection = new ManageCollection(this);
            manageCollection.Owner = this;
            manageCollection.ShowDialog();
        }

        private List<A_Component> loadStoredItems()
        {
            return _database.queryAllInventory();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _database.updateInventory(_itemList, _itemRemovals);
        }
    }
}
