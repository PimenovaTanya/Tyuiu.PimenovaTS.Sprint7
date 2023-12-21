using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.PimenovaTS.Sprint7.Project.V2.Lib;

namespace Tyuiu.PimenovaTS.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxMain_PTS.Text = ds.CollectTextFromFile(Convert.ToString(textBoxShop_PTS.Text), Convert.ToInt32(textBoxCategory_PTS.Text));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxShop_PTS_TextChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
