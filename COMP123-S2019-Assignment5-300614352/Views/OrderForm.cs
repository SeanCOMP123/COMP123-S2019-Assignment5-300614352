using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Diagnostics;
/*
 * Student Name: Sean Kwak
 * Student ID: 300614352
 * Description : This is the OrderForm - Finalize the order for the computer user choose. 
 *                                       user can go back to select form.
 */

namespace COMP123_S2019_Assignment5_300614352.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is an event handler for undoToolStripMenuItem click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is an event hanlder for extiToolStripMenuItem click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is an event handler for aboutToolStripMenuItem click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.ABOUT_FORM].Show();
        }

        /// <summary>
        /// This is an event handler when OrderForm is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            //Assign label.text with property values
            ConditionOutputLabel.Text = Program.product.condition;
            PriceOutputLabel.Text = Program.product.cost.ToString();
            PlatformOutputLabel.Text = Program.product.platform;
            OSOutputLabel.Text = Program.product.OS;
            ManufacturerOutputLabel.Text = Program.product.manufacturer;
            ModelOutputLabel.Text = Program.product.model;
            MemoryOutputLabel.Text = Program.product.RAM_size;
            OrderFormLCDSizeOutputLabel.Text = Program.product.screensize;
            HDDOutputLabel.Text = Program.product.HDD_size;
            CPUBrandOutputLabel.Text = Program.product.CPU_brand;
            CPUBrandOutputLabel.Text = Program.product.CPU_number;
            GPUTypeOutputLabel.Text = Program.product.GPU_Type;
            CPUTypeOutputLabel.Text = Program.product.CPU_type;
            CPUSpeedOutputLabel.Text = Program.product.CPU_speed;
            WebCamOutputLabel.Text = Program.product.webcam;

            //calculate salestax and total cost
            decimal salestax = (decimal)Program.product.cost * (decimal)0.13;
            decimal total = salestax + (decimal)Program.product.cost;
            SalesTaxOutputLabel.Text = salestax.ToString("0.00##");
            TotalOutputLabel.Text = total.ToString("0.00##");

            //Condition for which picture should be in the OrderFormPictureBox
            if (Program.product.manufacturer.Contains("Toshiba"))
            {
                FileStream image = new FileStream(@"Images\TOSHIBALaptopjpg.jpg", FileMode.Open, FileAccess.Read);

                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();
            }
            if (Program.product.manufacturer.Contains("Acer"))
            {
                FileStream image = new FileStream(@"Images\AcerLaptop.jpg", FileMode.Open, FileAccess.Read);

                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.product.manufacturer.Contains("HP") && Program.product.platform.Contains("Laptop"))
            {
                FileStream image = new FileStream(@"Images\HPLaptop.png", FileMode.Open, FileAccess.Read);
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            else if (Program.product.manufacturer.Contains("HP") && Program.product.platform.Contains("Desktop"))
            {
                FileStream image = new FileStream(@"Images\HPDesktop.jpg", FileMode.Open, FileAccess.Read);
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();
            }
            if (Program.product.manufacturer.Contains("Apple"))
            {
                FileStream image = new FileStream(@"Images\AppleDesktop.png", FileMode.Open, FileAccess.Read);
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.product.manufacturer.Contains("CybertronPC"))
            {
                FileStream image = new FileStream(@"Images\CybertronPC.png", FileMode.Open, FileAccess.Read);
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.product.manufacturer.Contains("Gateway"))
            {
                FileStream image = new FileStream(@"Images\GatewayPC.png", FileMode.Open, FileAccess.Read);
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.product.manufacturer.Contains("iBUYPOWER"))
            {
                FileStream image = new FileStream(@"Images\IBUYPOWERDesktop.png", FileMode.Open, FileAccess.Read);

                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.product.manufacturer.Contains("Lenovo"))
            {
                FileStream image = new FileStream(@"Images\LenovoLaptop.jpg", FileMode.Open, FileAccess.Read);
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.product.manufacturer.Contains("Asus"))
            {
                FileStream image = new FileStream(@"Images\AsusLaptop.png", FileMode.Open, FileAccess.Read);
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
        }
        /// <summary>
        /// This is an event handler for printToolStripMenuItem click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderFormPrintForm.PrintAction = PrintAction.PrintToPreview;
            OrderFormPrintForm.Print();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        { 
            DialogResult ok = MessageBox.Show("Thank you for doing business with Dollar Computers!\n\n" +
                            "Your order will be processed in 7-10 business days", "Your order has been received",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (DialogResult.OK == ok)
            {
                Application.Exit();
            }
        }
    }
}
