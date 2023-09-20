using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class SplashScreem : Form
    {
        public SplashScreem()
        {
            InitializeComponent();
        }

        private void SplashScreem_Shown(object sender, EventArgs e)
        {
            this.Refresh();
            for (int i = 0; i < 101; i++)
            {
                prcCarregar.Value = i;
                Thread.Sleep(4);
            }
            prcCarregar.Value = 99;
            Thread.Sleep(10);

            this.Close();
        }
    }
}
