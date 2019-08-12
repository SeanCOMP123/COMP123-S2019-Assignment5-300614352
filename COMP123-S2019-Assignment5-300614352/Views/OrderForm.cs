using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5_300614352.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.ABOUT_FORM].Show();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ConditionOutputLabel.Text = Program.components.condition;
            PriceOutputLabel.Text = Program.components.cost;
            PlatformOutputLabel.Text = Program.components.platform;
            OSOutputLabel.Text = Program.components.os;
            ManufacturerOutputLabel.Text = Program.components.manufacturer;
            ModelOutputLabel.Text = Program.components.model;
            MemoryOutputLabel.Text = Program.components.ram_size;
            OrderFormLCDSizeOutputLabel.Text = Program.components.screensize;
            HDDOutputLabel.Text = Program.components.hdd_size;
            CPUBrandOutputLabel.Text = Program.components.cpu_brand;
            CPUBrandOutputLabel.Text = Program.components.cpu_number;
            GPUTypeOutputLabel.Text = Program.components.gpu_type;
            CPUTypeOutputLabel.Text = Program.components.cpu_type;
            CPUSpeedOutputLabel.Text = Program.components.cpu_speed;
            WebCamOutputLabel.Text = Program.components.webcam;

            double salestax = double.Parse(Program.components.cost)*0.13;
            double total = salestax + double.Parse(Program.components.cost);
            SalesTaxOutputLabel.Text = (salestax.ToString("0.00##"));
            TotalOutputLabel.Text = total.ToString("0.00##"); ;
        }
    }
}
