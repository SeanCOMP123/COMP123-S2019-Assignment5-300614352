using COMP123_S2019_Assignment5_300614352.Models;
using COMP123_S2019_Assignment5_300614352.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5_300614352
{
    static class Program
    {
        public static Dictionary<FormNames, Form> Forms;
        public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Instantiate forms
            Forms = new Dictionary<FormNames, Form>();
            //Add forms to dictionary
            Forms.Add(FormNames.SPLASH_FORM, new SplashForm());
            Forms.Add(FormNames.START_FORM, new StartForm());
            Forms.Add(FormNames.PRODUCT_INFO_FORM, new ProductInfoForm());
            Forms.Add(FormNames.ORDER_FORM, new OrderForm());
            Forms.Add(FormNames.SELECT_FORM, new SelectForm());
            Forms.Add(FormNames.ABOUT_FORM, new AboutForm());
            product = new Product();
           
            Application.Run(new SplashForm());
        }
    }
}
