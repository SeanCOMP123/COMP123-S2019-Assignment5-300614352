using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Sean Kwak
 * Student ID: 300614352
 * Description : This is the ProductInfoForm - show all the components for a computer that user selected for this application.
 */

namespace COMP123_S2019_Assignment5_300614352.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is an event handler for NextButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.ORDER_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is an event handler for exitToolStripMenuItem click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is an event handler for SelectAnotherProductButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
          
            this.Hide();
        }
        /// <summary>
        /// This is an event handler when ProductInfoForm is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDOutputLabel.Text = Program.Product.productID.ToString();
            ConditionOutputLabel.Text = Program.Product.condition;
            PriceOutputLabel.Text = Program.Product.cost;
            PlatFormOutputLabel.Text = Program.Product.platform;
            OSOutputLabel.Text = Program.Product.os;
            ManufacturerOutputLabel.Text = Program.Product.manufacturer;
            ModelOutputLabel.Text = Program.Product.model;
            MemoryOutputLabel.Text = Program.Product.ram_size;
            LCDSizeOutputLabel.Text = Program.Product.screensize;
            HDDOutputLabel.Text = Program.Product.hdd_size;
            CPUBrandOutputLabel.Text = Program.Product.cpu_brand;
            CPUnumberOutputLabel.Text = Program.Product.cpu_number;
            GPUTypeOutputLabel.Text = Program.Product.gpu_type;
            CPUTypeOutputLabel.Text = Program.Product.cpu_type;
            CPUSpeedOutputLabel.Text = Program.Product.cpu_speed;
            WebCamOutputLabel.Text = Program.Product.webcam;
        }
        /// <summary>
        /// This is an event handler for openToolStripMenuItem click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog

            ProductInfoFormOpenFileDialog.FileName = "SavedProduct.txt";

            ProductInfoFormOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            ProductInfoFormOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";



            // open the file dialog

            var result = ProductInfoFormOpenFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)

            {
                try
                {
                    // Open your stream to read

                    using (StreamReader inputStream = new StreamReader(

                        File.Open(ProductInfoFormOpenFileDialog.FileName, FileMode.Open)))
                    {

                        // Read stuff into the Student class


                        Program.Product.productID= int.Parse(inputStream.ReadLine());
                        Program.Product.condition= inputStream.ReadLine();
                        Program.Product.cost= inputStream.ReadLine();
                        Program.Product.platform= inputStream.ReadLine();
                        Program.Product.os= inputStream.ReadLine();
                        Program.Product.manufacturer= inputStream.ReadLine();
                        Program.Product.model= inputStream.ReadLine();
                        Program.Product.ram_size= inputStream.ReadLine();
                        Program.Product.screensize= inputStream.ReadLine();
                        Program.Product.hdd_size= inputStream.ReadLine();
                        Program.Product.cpu_brand= inputStream.ReadLine();
                        Program.Product.cpu_number= inputStream.ReadLine();
                        Program.Product.gpu_type= inputStream.ReadLine();
                        Program.Product.cpu_type= inputStream.ReadLine();
                        Program.Product.cpu_speed = inputStream.ReadLine();
                        Program.Product.webcam = inputStream.ReadLine();
                 // cleanup

                        inputStream.Close();
                        inputStream.Dispose();
                        ProductInfoForm_Activated(sender, e);

                    }

                }
                catch (IOException exception)

                {
                    MessageBox.Show("Error: " + exception.Message, "File I/O Error",

                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        /// <summary>
        /// This is an event handler for saveToolStripMenuItem click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog

            ProductInfoFormSaveFileDialog.FileName = "SavedProduct.txt";

            ProductInfoFormSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            ProductInfoFormSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";



            // open file dialog - Modal Form

            var result = ProductInfoFormSaveFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)

            {
                // open file to write

                using (StreamWriter outputStream = new StreamWriter(

                    File.Open(ProductInfoFormSaveFileDialog.FileName, FileMode.Create)))

                {

                    // write stuff to the file
                    outputStream.WriteLine(Program.Product.productID);
                    outputStream.WriteLine(Program.Product.condition);
                    outputStream.WriteLine(Program.Product.cost);
                    outputStream.WriteLine(Program.Product.platform);
                    outputStream.WriteLine(Program.Product.os);
                    outputStream.WriteLine(Program.Product.manufacturer);
                    outputStream.WriteLine(Program.Product.model);
                    outputStream.WriteLine(Program.Product.ram_size);
                    outputStream.WriteLine(Program.Product.screensize);
                    outputStream.WriteLine(Program.Product.hdd_size);
                    outputStream.WriteLine(Program.Product.cpu_brand);
                    outputStream.WriteLine(Program.Product.cpu_number);
                    outputStream.WriteLine(Program.Product.gpu_type);
                    outputStream.WriteLine(Program.Product.cpu_type);
                    outputStream.WriteLine(Program.Product.cpu_speed);
                    outputStream.WriteLine(Program.Product.webcam); 


                    // close the file

                    outputStream.Close();
               // dispose of the memory

                    outputStream.Dispose();
                }

                MessageBox.Show("File Saved", "Saving...",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
