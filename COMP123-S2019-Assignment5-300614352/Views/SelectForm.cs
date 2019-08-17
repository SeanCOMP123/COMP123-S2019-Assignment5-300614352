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
            var rows = ProductDataGridView.Rows;
            //var columnCount = ProductDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;
            rows[rowIndex].Selected = true;

            YourSelectionOutputLabel.Text = cells[1].Value.ToString() +" "+ cells[2].Value.ToString() + " " + cells[3].Value.ToString();

            //string outputString = string.Empty;
            //for (int index = 0; index < columnCount; index++)
            //{
            //    outputString += cells[index].Value.ToString() + " ";
            //}

            //store values into property
            Program.product.productID = short.Parse(cells[0].Value.ToString());
            Program.product.cost = decimal.Parse(cells[1].Value.ToString());
            Program.product.manufacturer = cells[2].Value.ToString();
            Program.product.model = cells[3].Value.ToString();
            Program.product.RAM_type = cells[4].Value.ToString();
            Program.product.RAM_size = cells[5].Value.ToString();
            Program.product.displaytype = cells[6].Value.ToString();
            Program.product.screensize = cells[7].Value.ToString();
            Program.product.resolution = cells[8].Value.ToString();
            Program.product.CPU_Class = cells[9].Value.ToString();
            Program.product.CPU_brand = cells[10].Value.ToString();
            Program.product.CPU_type = cells[11].Value.ToString();
            Program.product.CPU_speed = cells[12].Value.ToString();
            Program.product.CPU_number = cells[13].Value.ToString();
            Program.product.condition = cells[14].Value.ToString();
            Program.product.OS = cells[15].Value.ToString();
            Program.product.platform = cells[16].Value.ToString();
            Program.product.HDD_size = cells[17].Value.ToString();
            Program.product.HDD_speed = cells[18].Value.ToString();
            Program.product.GPU_Type = cells[19].Value.ToString();
            Program.product.optical_drive = cells[20].Value.ToString();
            Program.product.Audio_type = cells[21].Value.ToString();
            Program.product.LAN = cells[22].Value.ToString();
            Program.product.WIFI = cells[23].Value.ToString();
            Program.product.width = cells[24].Value.ToString();
            Program.product.height = cells[25].Value.ToString();
            Program.product.depth = cells[26].Value.ToString();
            Program.product.weight = cells[27].Value.ToString();
            Program.product.moust_type = cells[28].Value.ToString();
            Program.product.power = cells[29].Value.ToString();
            Program.product.webcam = cells[30].Value.ToString();
        }
    }   
}
