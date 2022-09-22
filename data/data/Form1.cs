using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NAZWISKOLABEL_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            string s3 = dateTimePicker1.Text;
            if (s1.Length == 0 || s2.Length == 0)
            {
                MessageBox.Show("Nie podano wszystkich danych");
            }
            else
            {
                MessageBox.Show("Podane imię: " + s1 + ", nazwisko: " + s2 + ", data urodzenia: " + s3);
            }
        }
    }
}
