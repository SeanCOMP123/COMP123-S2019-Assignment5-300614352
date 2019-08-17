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
 * Description : This is the StartForm for the application
 */

namespace COMP123_S2019_Assignment5_300614352.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is an event handler for ExitButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is an event handler for StartNewOrderButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is an event handler for OpenSaveOrderButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
           
            // configure the file dialog
            StartFormOpenFileDialog.FileName = "SavedProduct.txt";
            StartFormOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            StartFormOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            // open the file dialog
            var result = StartFormOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // Open your stream to read

                    using (StreamReader inputStream = new StreamReader(
                        File.Open(StartFormOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // Read stuff into the Student class
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();
                        // cleanup
                        inputStream.Close();
                        inputStream.Dispose();

                    }

                }
                catch (IOException exception)

                {
                    MessageBox.Show("Error: " + exception.Message, "File I/O Error",

                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //show ProductInfoForm
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is an event handler when startFrom is Loaded. Load the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_Load(object sender, EventArgs e)
        {
            FileStream image = new FileStream(@"Images\DollarStore.jpg", FileMode.Open, FileAccess.Read);
            StartFormPictureBox.Image = Image.FromStream(image);
            image.Close();
        }
    }    
}
