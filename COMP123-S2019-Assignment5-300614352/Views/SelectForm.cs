using COMP123_S2019_Assignment5_300614352.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Sean Kwak
 * Student ID: 300614352
 * Description : This is the SelectForm that allow user to choose the computer product.
 */


namespace COMP123_S2019_Assignment5_300614352.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is an event handler for CancelButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is an event handler for NextButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is event handler for SelectForm being loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();

            }
        }
        /// <summary>
        /// This is an event handler for ProductDataGridView cell click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            Debug.WriteLine(rowIndex);
            var rows = ProductDataGridView.Rows;
            var columnCount = ProductDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;
            rows[rowIndex].Selected = true;

            YourSelectionOutputLabel.Text = cells[1].Value.ToString() + cells[2].Value.ToString() + cells[3].Value.ToString();

            //string outputString = string.Empty;
            //for (int index = 0; index < columnCount; index++)
            //{
            //    outputString += cells[index].Value.ToString() + " ";
            //}

            //store values into property
            Program.Product.productID = int.Parse(cells[0].Value.ToString());
            Program.Product.cost = cells[1].Value.ToString();
            Program.Product.manufacturer = cells[2].Value.ToString();
            Program.Product.model = cells[3].Value.ToString();
            Program.Product.ram_type = cells[4].Value.ToString();
            Program.Product.ram_size = cells[5].Value.ToString();
            Program.Product.displaytype = cells[6].Value.ToString();
            Program.Product.screensize = cells[7].Value.ToString();
            Program.Product.resolution = cells[8].Value.ToString();
            Program.Product.cpu_class = cells[9].Value.ToString();
            Program.Product.cpu_brand = cells[10].Value.ToString();
            Program.Product.cpu_type = cells[11].Value.ToString();
            Program.Product.cpu_speed = cells[12].Value.ToString();
            Program.Product.cpu_number = cells[13].Value.ToString();
            Program.Product.condition = cells[14].Value.ToString();
            Program.Product.os = cells[15].Value.ToString();
            Program.Product.platform = cells[16].Value.ToString();
            Program.Product.hdd_size = cells[17].Value.ToString();
            Program.Product.hdd_speed = cells[18].Value.ToString();
            Program.Product.gpu_type = cells[19].Value.ToString();
            Program.Product.optical_drive = cells[20].Value.ToString();
            Program.Product.audio_type = cells[21].Value.ToString();
            Program.Product.lan = cells[22].Value.ToString();
            Program.Product.wifi = cells[23].Value.ToString();
            Program.Product.width = cells[24].Value.ToString();
            Program.Product.height = cells[25].Value.ToString();
            Program.Product.depth = cells[26].Value.ToString();
            Program.Product.weight = cells[27].Value.ToString();
            Program.Product.mouse_type = cells[28].Value.ToString();
            Program.Product.power = cells[29].Value.ToString();
            Program.Product.webcam = cells[30].Value.ToString();
        }
    }
}
