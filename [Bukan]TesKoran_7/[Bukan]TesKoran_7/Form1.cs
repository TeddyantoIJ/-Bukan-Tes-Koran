using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Bukan_TesKoran_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uiProfile1.Hide();
            uiLevel1.Hide();
            uiGame1.Hide();
            Start.Show();
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            show(uiLevel1);
        }
        private void show(UserControl masuk)
        {
            masuk.Visible = true;
            masuk.BringToFront();
        }
        private void hide(UserControl masuk)
        {
            masuk.Visible = false;
            masuk.SendToBack();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            uiProfile1.Hide();
            uiLevel1.Hide();
            uiGame1.Show();
            Start.Hide();
           
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            uiProfile1.Show();
            uiLevel1.Hide();
            uiGame1.Hide();
            Start.Hide();
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            mySetting.BringToFront();
            mySetting.Visible = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            mySetting.Visible = false;
        }
    }
}
