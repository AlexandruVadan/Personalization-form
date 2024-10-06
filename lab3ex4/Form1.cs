using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.Text = "Personalizare forma";
            }
            if(radioButton2.Checked)
            {
                this.MaximizeBox = false;
                this.MinimizeBox = false;
            }
            if(radioButton3.Checked)
            {
                Button btnAdd = new Button();
                btnAdd.BackColor = Color.Gray;
                btnAdd.Text = "Iesi din aplicatie";
                btnAdd.Location = new System.Drawing.Point(90, 25);
                btnAdd.Size = new System.Drawing.Size(200, 50);
                flowLayoutPanel1.Controls.Add(btnAdd);

                btnAdd.Click += BtnAdd_Click;
            }
            if (radioButton4.Checked)
            {

                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("back.jpg");
                
                pb1.Size = new Size(2000, 2000);
                this.Controls.Add(pb1);

                

            }

            if(radioButton5.Checked)
            {
                PictureBox pb2 = new PictureBox();
                pb2.Image = Image.FromFile("cerc.jpg");
                pb2.Location = new Point(100, 100);
                pb2.Size = new Size(700, 700);
                this.Controls.Add(pb2);
                flowLayoutPanel1.Controls.Add(pb2);

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

      

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
