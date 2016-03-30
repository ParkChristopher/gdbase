using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDBase
{
    public partial class FormMain : Form
    {
        private DatabaseManager _database;
        private List<A_Component> _itemRemovals;
        private List<A_Component> _itemList;
        private List<A_Component> _masterList;
        
        public FormMain()
        {
            InitializeComponent();
            comboBoxSystem.SelectedIndex = 0;
            _database = new DatabaseManager();
            _itemList = new List<A_Component>();
            _itemRemovals = new List<A_Component>();
            _masterList = new List<A_Component>();

            _masterList.AddRange(loadStoredItems());
            _itemList.AddRange(_masterList);
            updateGridView(_itemList);
        }

        public List<A_Component> Master
        { get { return _masterList; } }

        public List<A_Component> Items
        {
            get { return _itemList; }  
        }

        public List<A_Component> Removals
        {
            get { return _itemRemovals; }
        }

        public void updateGridView(List<A_Component> list)
        {
            dataGridViewItems.Rows.Clear();
            foreach (A_Component item in list)
                dataGridViewItems.Rows.Add(item.Name, item.System, item.Year);
        }

        private void buttonManageCollection_Click(object sender, EventArgs e)
        {
            CollectionManager collectionDialog = new CollectionManager(this);
            collectionDialog.Owner = this;
            collectionDialog.ShowDialog();
        }

        private List<A_Component> loadStoredItems()
        {
            return _database.queryAllInventory();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _database.updateInventory(_masterList, _itemRemovals);
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            List<A_Component> tempList = new List<A_Component>();
            Regex pattern = new Regex("(" + textBoxSearch.Text.ToLower() + ")");

            foreach (A_Component item in _itemList)
                if (pattern.IsMatch(item.Name.ToLower()))
                    tempList.Add(item);
            
            updateGridView(tempList);
        }

    }
}
