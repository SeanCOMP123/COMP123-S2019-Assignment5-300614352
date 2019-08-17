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
            ProductIDOutputLabel.Text = Program.product.productID.ToString();
            ConditionOutputLabel.Text = Program.product.condition;
            PriceOutputLabel.Text = Program.product.cost.ToString();
            PlatFormOutputLabel.Text = Program.product.platform;
            OSOutputLabel.Text = Program.product.OS;
            ManufacturerOutputLabel.Text = Program.product.manufacturer;
            ModelOutputLabel.Text = Program.product.model;
            MemoryOutputLabel.Text = Program.product.RAM_size;
            LCDSizeOutputLabel.Text = Program.product.screensize;
            HDDOutputLabel.Text = Program.product.HDD_size;
            CPUBrandOutputLabel.Text = Program.product.CPU_brand;
            CPUnumberOutputLabel.Text = Program.product.CPU_number;
            GPUTypeOutputLabel.Text = Program.product.GPU_Type;
            CPUTypeOutputLabel.Text = Program.product.CPU_type;
            CPUSpeedOutputLabel.Text = Program.product.CPU_speed;
            WebCamOutputLabel.Text = Program.product.webcam;
        }
        /// <summary>
        /// This is an event handler for openToolStripMenuItem click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog

            ProductInfoFormOpenFileDialog.FileName = "";

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


                        Program.product.productID= short.Parse(inputStream.ReadLine());
                        Program.product.condition= inputStream.ReadLine();
                        Program.product.cost= decimal.Parse(inputStream.ReadLine());
                        Program.product.platform= inputStream.ReadLine();
                        Program.product.OS= inputStream.ReadLine();
                        Program.product.manufacturer= inputStream.ReadLine();
                        Program.product.model= inputStream.ReadLine();
                        Program.product.RAM_size= inputStream.ReadLine();
                        Program.product.screensize= inputStream.ReadLine();
                        Program.product.HDD_size= inputStream.ReadLine();
                        Program.product.CPU_brand= inputStream.ReadLine();
                        Program.product.CPU_number= inputStream.ReadLine();
                        Program.product.GPU_Type= inputStream.ReadLine();
                        Program.product.CPU_type= inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();
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

            ProductInfoFormSaveFileDialog.FileName = "Product.txt";

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
                    outputStream.WriteLine(Program.product.productID);
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.cost);
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_size);
                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.HDD_size);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.GPU_Type);
                    outputStream.WriteLine(Program.product.CPU_type);
                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.webcam); 


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
