using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questiion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total;
        private void Form1_Load(object sender, EventArgs e)
        {

            //rdoadd.Enabled = true;
            //rdoMult.Enabled = true;
            //rdoSub.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            int first = int.Parse(txtFirst.Text);
            int Second = int.Parse(txtSecond.Text);

            total = first + Second;
            if (rdoadd.Checked == true)
            {

                button2.Hide();
                button3.Hide();
                MessageBox.Show("The Total is :" + total);
                txtFirst.Clear();
                txtSecond.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            int first  = int.Parse(txtFirst.Text);
            int Second = int.Parse(txtSecond.Text);

            total = first - Second;
            if (rdoSub.Checked == true)
            {


                button1.Hide();
                button3.Hide();



                MessageBox.Show("The Total is :"+ total);
                txtFirst.Clear();
                txtSecond.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
         

            try
            {

                int first = int.Parse(txtFirst.Text);
                int Second = int.Parse(txtSecond.Text);

                total = first * Second;
                if (rdoMult.Checked == true)
                {
                    button1.Hide();
                    button2.Hide();

                    MessageBox.Show("The Total is :" + total);
                    txtFirst.Clear();
                    txtSecond.Clear();


                }
            }

            catch (Exception)
            {

            }
        
     
           }

        private void rdoadd_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        private void rdoMult_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdoSub_CheckedChanged(object sender, EventArgs e)
        {
         
        }   
    }
}
