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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.ORDER_FORM].Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            components = new Component();
            this.Hide();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            ProductIDOutputLabel.Text = Program.components.productID.ToString();
            ConditionOutputLabel.Text = Program.components.condition;
            PriceOutputLabel.Text = Program.components.cost;
            PlatFormOutputLabel.Text = Program.components.platform;
            OSOutputLabel.Text = Program.components.os;
            ManufacturerOutputLabel.Text = Program.components.manufacturer;
            ModelOutputLabel.Text = Program.components.model;
            MemoryOutputLabel.Text = Program.components.ram_size;
            LCDSizeOutputLabel.Text = Program.components.screensize;
            HDDOutputLabel.Text = Program.components.hdd_size;
            CPUBrandOutputLabel.Text = Program.components.cpu_brand;
            CPUnumberOutputLabel.Text = Program.components.cpu_number;
            GPUTypeOutputLabel.Text = Program.components.gpu_type;
            CPUTypeOutputLabel.Text = Program.components.cpu_type;
            CPUSpeedOutputLabel.Text = Program.components.cpu_speed;
            WebCamOutputLabel.Text = Program.components.webcam;

        }
        public void In
    }
}
