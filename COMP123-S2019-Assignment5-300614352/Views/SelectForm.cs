using COMP123_S2019_Assignment5_300614352.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COMP123_S2019_Assignment5_300614352.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();

            }
        }

        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var columnCount = ProductDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;
            rows[rowIndex].Selected = true;

            YourSelectionOutputLabel.Text = cells[1].Value.ToString() + cells[2].Value.ToString() + cells[3].Value.ToString();

            string outputString = string.Empty;
            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value.ToString()+ " ";
            }
            
            Program.components.productID = int.Parse(cells[0].Value.ToString());
            Program.components.cost = cells[1].Value.ToString();
            Program.components.manufacturer = cells[2].Value.ToString();
            Program.components.model = cells[3].Value.ToString();
            Program.components.ram_type = cells[4].Value.ToString();
            Program.components.ram_size = cells[5].Value.ToString();
            Program.components.displaytype = cells[6].Value.ToString();
            Program.components.screensize = cells[7].Value.ToString();
            Program.components.resolution = cells[8].Value.ToString();
            Program.components.cpu_class = cells[9].Value.ToString();
            Program.components.cpu_brand = cells[10].Value.ToString();
            Program.components.cpu_type = cells[11].Value.ToString();
            Program.components.cpu_speed = cells[12].Value.ToString();
            Program.components.cpu_number = cells[13].Value.ToString();   
            Program.components.condition = cells[14].Value.ToString();
            Program.components.os = cells[15].Value.ToString();
            Program.components.platform = cells[16].Value.ToString();
            Program.components.hdd_size = cells[17].Value.ToString();
            Program.components.hdd_speed = cells[18].Value.ToString();
            Program.components.gpu_type = cells[19].Value.ToString();
            Program.components.optical_drive = cells[20].Value.ToString();
            Program.components.audio_type = cells[21].Value.ToString();
            Program.components.lan = cells[22].Value.ToString();
            Program.components.wifi = cells[23].Value.ToString();
            Program.components.width = cells[24].Value.ToString();
            Program.components.height = cells[25].Value.ToString();
            Program.components.depth= cells[26].Value.ToString();
            Program.components.weight = cells[27].Value.ToString();
            Program.components.mouse_type = cells[28].Value.ToString();
            Program.components.power = cells[29].Value.ToString();
            Program.components.webcam = cells[30].Value.ToString();
        }
    }
}
