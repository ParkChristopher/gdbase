using System;
using System.IO;
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
    public partial class CollectionManager : Form
    {
        private FormMain _parent;
        private Bitmap _imgPreview;

        public CollectionManager(FormMain parent)
        {
            InitializeComponent();
            _parent = parent;
            _imgPreview = new Bitmap(global::GDBase.Properties.Resources.imgStockImg);
            pictureBoxPreview.Image = _imgPreview;
        }

        public void updateGridView()
        {
            List<A_Component> list = _parent.Items;
            dataGridViewRemoveList.Rows.Clear();

            foreach (A_Component item in list)
                dataGridViewRemoveList.Rows.Add(item.Name);

            _parent.updateGridView(list);
        }

        private void tabRemove_Enter(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Add cover path as 4th argument


            addItem(new Game(textBoxNameAdd.Text,
                comboBoxSystemAdd.Text,
                Convert.ToInt32(textBoxYearAdd.Text),
                ""));
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result;
            string filePath;

            fileDialog.Filter = "JPEG Files (.jpg)|*.jpg|PNG Files (.png)|*.png|All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            result = fileDialog.ShowDialog(this);


            if (result == DialogResult.OK)
            {
                 
                filePath = Path.GetFullPath(fileDialog.SafeFileName);
                textBoxCoverAdd.Text = filePath;
                try
                {
                    //Need to save file to project directory and then get its file
                    //path, then load it.
                    //Bitmap coverArt = new Bitmap(fileDialog.OpenFile());
                    //Bitmap coverArt = new Bitmap(fileDialog.FileName);
                    Bitmap coverArt = (Bitmap)Bitmap.FromFile(filePath);
                    pictureBoxPreview.Image = coverArt; 
                
                }
                catch (Exception exptn)
                {
                    MessageBox.Show("Failed to open image file.");
                }
            }
        }

        private void addItem(A_Component item)
        {
            List<A_Component> list = _parent.Items;
            
            list.Add(item);
            updateGridView();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            List<A_Component> list = _parent.Items;
            List<A_Component> removalList = _parent.Removals;
            List<A_Component> tempRemovals = new List<A_Component>();
            DialogResult result;
            string removal;

            foreach (DataGridViewRow row in dataGridViewRemoveList.SelectedRows)
            {
                removal = row.Cells[0].Value.ToString();

                foreach (A_Component item in list)
                    if (removal.Equals(item.Name))
                    {
                        tempRemovals.Add(item);
                        break;
                    }
            }

            result = MessageBox.Show("Are you sure you want to remove the "
                + tempRemovals.Count + " selected items?", "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if(result.Equals(DialogResult.Cancel))
                return;

            foreach (A_Component item in tempRemovals)
                removeItem(item);

            removalList.AddRange(tempRemovals);
        }

        private void removeItem(A_Component item)
        {
            List<A_Component> list = _parent.Items;
            List<A_Component> masterList = _parent.Master;

            list.Remove(item);
            masterList.Remove(item);
            updateGridView();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Focus();
            this.Dispose();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void textBoxPhotoAdd_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}
