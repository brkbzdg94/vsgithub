using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsgithub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int target = -5;
            int num = 3;

            target = -num;  // Noncompliant; target = -3. Is that really what's meant?
            target = +num; // Noncompliant; target = 3


            //var s = "foo";
            //var t = "fee fie foe " + s.ToString();  // Noncompliant
            //var someObject = new object();
            //var u = "" + someObject.ToString(); // Noncompliant
            //var v = string.Format("{0}", someObject.ToString()); // Noncompliant
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güle Güle");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var t_goto = new SonarTest();
            return;
            t_goto.T_Goto();
        }
    }
}
