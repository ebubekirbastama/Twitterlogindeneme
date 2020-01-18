using BastamaSeleniumTwitterLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Ebubekir Bastama Selenium Twitter Login Giriş Projesi
/// Nuget Manager ile BastamaSeleniumTwitterLogin, Selenium WebDriver,Selenium Chrome Driver Yüklenmesi gerekmektedir.
/// </summary>
namespace Twitterlogindeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] girisbilgileri = {
                "ali",
                "kral"
            };
            string[] xpathbilgileri = {
                "//div[@class='clearfix field']//input[@placeholder='Telefon, e-posta veya kullanıcı adı']",
                "//div[@class='clearfix field']//input[@placeholder='Şifre']",
                "//button[@class='submit EdgeButton EdgeButton--primary EdgeButtom--medium']"
            };
            bastamaseleniumtwitterlogin.TwitterLogin("https://twitter.com/login", "", 2000, girisbilgileri, xpathbilgileri);
        }
    }
}
