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
                        Program.Product.productID = int.Parse(inputStream.ReadLine());
                        Program.Product.condition = inputStream.ReadLine();
                        Program.Product.cost = inputStream.ReadLine();
                        Program.Product.platform = inputStream.ReadLine();
                        Program.Product.os = inputStream.ReadLine();
                        Program.Product.manufacturer = inputStream.ReadLine();
                        Program.Product.model = inputStream.ReadLine();
                        Program.Product.ram_size = inputStream.ReadLine();
                        Program.Product.screensize = inputStream.ReadLine();
                        Program.Product.hdd_size = inputStream.ReadLine();
                        Program.Product.cpu_brand = inputStream.ReadLine();
                        Program.Product.cpu_number = inputStream.ReadLine();
                        Program.Product.gpu_type = inputStream.ReadLine();
                        Program.Product.cpu_type = inputStream.ReadLine();
                        Program.Product.cpu_speed = inputStream.ReadLine();
                        Program.Product.webcam = inputStream.ReadLine();
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
    }    
}
