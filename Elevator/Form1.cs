using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
    public partial class Form1 : Form
    {
        int peopleCount = 0;
        int floor = 0;


        public Form1()
        {
            InitializeComponent();

            label2.Text = floor.ToString();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (floor == 1)
            {
                pictureBox3.BringToFront();
                label2.Text = floor.ToString();
                await Task.Delay(3000);
                pictureBox2.BringToFront();

            }
            if (floor == 0)
            {
                if (textBox1.Text.Trim() == string.Empty)
                {
                    peopleCount = 0;
                }
                else
                {
                    peopleCount = Int32.Parse(textBox1.Text);
                }
                if (peopleCount < 13)
                {
                    pictureBox1.SendToBack();
                    pictureBox5.Show();
                    await Task.Delay(1000);
                    pictureBox5.Hide();

                    pictureBox3.BringToFront();
                    floor = 1;
                    peopleCount = 0;
                    label2.Text = floor.ToString();
                    await Task.Delay(3000);
                    pictureBox2.BringToFront();

                }
                else
                {
                    MessageBox.Show("Previše ljudi u dizalu.", "Upozorenje!");
                    label2.Text = floor.ToString();
                    peopleCount = 0;
                }
            }
            if (floor == 2)
            {
                if (textBox1.Text.Trim() == string.Empty)
                {
                    peopleCount = 0;
                }
                else
                {
                    peopleCount = Int32.Parse(textBox1.Text);
                }
                if (peopleCount < 13)
                {
                    pictureBox8.SendToBack();
                    pictureBox9.Show();
                    await Task.Delay(1000);
                    pictureBox9.Hide();

                    pictureBox3.BringToFront();
                    floor = 1;
                    peopleCount = 0;
                    label2.Text = floor.ToString();
                    await Task.Delay(3000);
                    pictureBox2.BringToFront();

                }
                else
                {
                    MessageBox.Show("Previše ljudi u dizalu.", "Upozorenje!");
                    label2.Text = floor.ToString();
                    peopleCount = 0;
                }
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (floor == 0)
            {
                pictureBox1.BringToFront();
                label2.Text = floor.ToString();
                await Task.Delay(3000);
                pictureBox4.BringToFront();


            }
            if (floor == 1)
            {
                if (textBox1.Text.Trim() == string.Empty)
                {
                    peopleCount = 0;
                }
                else
                {
                    peopleCount = Int32.Parse(textBox1.Text);
                }
                if (peopleCount < 13)
                {
                    pictureBox2.BringToFront();
                    pictureBox6.Show();

                    await Task.Delay(1000);
                    pictureBox6.Hide();


                    pictureBox1.BringToFront();
                    floor = 0;
                    peopleCount = 0;
                    label2.Text = floor.ToString();
                    await Task.Delay(3000);
                    pictureBox4.BringToFront();

                }

                else
                {
                    MessageBox.Show("Previše ljudi u dizalu.", "Upozorenje!");
                    label2.Text = floor.ToString();
                    peopleCount = 0;
                }
            }
            if (floor == 2)
            {
                if (textBox1.Text.Trim() == string.Empty)
                {
                    peopleCount = 0;
                }
                else
                {
                    peopleCount = Int32.Parse(textBox1.Text);
                }
                if (peopleCount < 13)
                {
                    pictureBox2.BringToFront();

                    pictureBox9.Show();

                    await Task.Delay(1000);
                    pictureBox9.Hide();

                    pictureBox6.Show();

                    await Task.Delay(1000);
                    pictureBox6.Hide();




                    pictureBox1.BringToFront();
                    floor = 0;
                    peopleCount = 0;
                    label2.Text = floor.ToString();
                    await Task.Delay(3000);
                    pictureBox4.BringToFront();

                }

                else
                {
                    MessageBox.Show("Previše ljudi u dizalu.", "Upozorenje!");
                    label2.Text = floor.ToString();
                    peopleCount = 0;
                }
            }


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (floor == 2)
            {
                pictureBox8.BringToFront();
                label2.Text = floor.ToString();
                await Task.Delay(3000);
                pictureBox7.BringToFront();


            }
            if (floor == 1)
            {
                if (textBox1.Text.Trim() == string.Empty)
                {
                    peopleCount = 0;
                }
                else
                {
                    peopleCount = Int32.Parse(textBox1.Text);
                }
                if (peopleCount < 13)
                {
                    pictureBox2.BringToFront();
                    pictureBox10.Show();

                    await Task.Delay(1000);
                    pictureBox10.Hide();


                    pictureBox8.BringToFront();
                    floor = 2;
                    peopleCount = 0;
                    label2.Text = floor.ToString();
                    await Task.Delay(3000);
                    pictureBox7.BringToFront();

                }

                else
                {
                    MessageBox.Show("Previše ljudi u dizalu.", "Upozorenje!");
                    label2.Text = floor.ToString();
                    peopleCount = 0;
                }
            }
            if (floor == 0)
            {
                if (textBox1.Text.Trim() == string.Empty)
                {
                    peopleCount = 0;
                }
                else
                {
                    peopleCount = Int32.Parse(textBox1.Text);
                }
                if (peopleCount < 13)
                {
                    pictureBox4.BringToFront();

                    pictureBox5.Show();
                    await Task.Delay(1000);
                    pictureBox5.Hide();

                    pictureBox10.Show();
                    await Task.Delay(1000);
                    pictureBox10.Hide();

                    pictureBox8.BringToFront();
                    floor = 2;
                    peopleCount = 0;
                    label2.Text = floor.ToString();
                    await Task.Delay(3000);
                    pictureBox7.BringToFront();

                }

                else
                {
                    MessageBox.Show("Previše ljudi u dizalu.", "Upozorenje!");
                    label2.Text = floor.ToString();
                    peopleCount = 0;
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {

        }
    }
}
