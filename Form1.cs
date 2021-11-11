using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ;
            if ((checkBox1.AutoCheck == true) && (checkBox2.AutoCheck == true)){
                textBox1.Text = "Выберите велечину из которй надо переводить";
            }
            else if(checkBox1.AutoCheck == true)
            {
                
            }
            else if (checkBox2.AutoCheck == true)
            {

            }


        }
    }
}
