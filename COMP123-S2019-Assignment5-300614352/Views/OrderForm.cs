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
            

        private void OrderForm_Activated(object sender, EventArgs e)
        {
                ConditionOutputLabel.Text = Program.Product.condition;
                PriceOutputLabel.Text = Program.Product.cost;
                PlatformOutputLabel.Text = Program.Product.platform;
                OSOutputLabel.Text = Program.Product.os;
                ManufacturerOutputLabel.Text = Program.Product.manufacturer;
                ModelOutputLabel.Text = Program.Product.model;
                MemoryOutputLabel.Text = Program.Product.ram_size;
                OrderFormLCDSizeOutputLabel.Text = Program.Product.screensize;
                HDDOutputLabel.Text = Program.Product.hdd_size;
                CPUBrandOutputLabel.Text = Program.Product.cpu_brand;
                CPUBrandOutputLabel.Text = Program.Product.cpu_number;
                GPUTypeOutputLabel.Text = Program.Product.gpu_type;
                CPUTypeOutputLabel.Text = Program.Product.cpu_type;
                CPUSpeedOutputLabel.Text = Program.Product.cpu_speed;
                WebCamOutputLabel.Text = Program.Product.webcam;

                double salestax = double.Parse(Program.Product.cost) * 0.13;
                double total = salestax + double.Parse(Program.Product.cost);
                SalesTaxOutputLabel.Text = salestax.ToString("0.00##");
                TotalOutputLabel.Text = total.ToString("0.00##");

            if (Program.Product.manufacturer.Contains("Toshiba"))
            {
                FileStream image = new FileStream(@"Images\TOSHIBALaptopjpg.jpg", FileMode.Open, FileAccess.Read);
               
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();
            }
             if (Program.Product.manufacturer.Contains("Acer"))
            {
                FileStream image = new FileStream(@"Images\AcerLaptop.jpg", FileMode.Open, FileAccess.Read);
               
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.Product.manufacturer.Contains("HP")&&Program.Product.platform.Contains("Laptop"))
            {
                FileStream image = new FileStream(@"Images\HPLaptop.png", FileMode.Open, FileAccess.Read);
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            else if (Program.Product.manufacturer.Contains("HP") && Program.Product.platform.Contains("Desktop"))
            {
                FileStream image = new FileStream(@"Images\HPDesktop.jpg", FileMode.Open, FileAccess.Read);    
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();
            }
            if (Program.Product.manufacturer.Contains("Apple"))
            {
                FileStream image = new FileStream(@"Images\AppleDesktop.png", FileMode.Open, FileAccess.Read);
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.Product.manufacturer.Contains("CybertronPC"))
            {
                FileStream image = new FileStream(@"Images\CybertronPC.png", FileMode.Open, FileAccess.Read);               
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.Product.manufacturer.Contains("Gateway"))
            {
                FileStream image = new FileStream(@"Images\GatewayPC.png", FileMode.Open, FileAccess.Read);            
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.Product.manufacturer.Contains("iBUYPOWER"))
            {
                FileStream image = new FileStream(@"Images\IBUYPOWERDesktop.png", FileMode.Open, FileAccess.Read);
              
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.Product.manufacturer.Contains("Lenovo"))
            {
                FileStream image = new FileStream(@"Images\LenovoLaptop.jpg", FileMode.Open, FileAccess.Read);             
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }
            if (Program.Product.manufacturer.Contains("Asus"))
            {
                FileStream image = new FileStream(@"Images\AsusLaptop.png", FileMode.Open, FileAccess.Read);
                OrderFormPictureBox.Image = Image.FromStream(image);
                image.Close();

            }




        }
        private static Image ResizeImage(Image image, Size newSize)
        {
            Image newImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics GFX = Graphics.FromImage((Bitmap)newImage))

            {
                GFX.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }
            return newImage;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderFormPrintForm.PrintAction = PrintAction.PrintToPreview;
            OrderFormPrintForm.Print();
        }
    }
}
