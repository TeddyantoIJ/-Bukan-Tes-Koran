using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Bukan_TesKoran_7
{
    public partial class Setting : UserControl
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        private void label2_Click(object sender, EventArgs e)
        {
            History his = new History();
            his.ShowDialog(this);
        }

        private void Setting_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
