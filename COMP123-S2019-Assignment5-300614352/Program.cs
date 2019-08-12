using COMP123_S2019_Assignment5_300614352.Models;
using COMP123_S2019_Assignment5_300614352.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*-------------------------------------------------
 * Studnet Name: Sean(Myoung seop) Kwak
 * Studnet Number: 300614352
 * Name of Assignment: Dollar Computers Application
 * Date of Creation: 2019-07-31
 * Last day of Revision: 2019-08-02
 ---------------------------------------------------*/
namespace COMP123_S2019_Assignment5_300614352
{
    static class Program
    {
        public static Dictionary<FormNames, Form> Forms;
        public static Product product;
        public static Component components;
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
            components = new Component();
           
            Application.Run(Forms[FormNames.SPLASH_FORM]);
        }
    }
}
