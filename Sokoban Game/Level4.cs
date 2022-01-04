using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban_Game
{
    public partial class Level4 : Form
    {

        int mov = 70;
        Wall[,] ar = new Wall[10, 10];

        Sokoban m;
        Crate boxA;
        Crate boxB;
        Crate boxC;

        public Level4()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Init();
            Draw();
        }

        private void Init()
        {
            for (int x = 0; x < 100; x++)
            {
                int a = x / 10;
                int b = x % 10;

                ar[a, b] = new Wall(b, a);
            }

            ar[1, 8].istarget = true;
            ar[8, 2].istarget = true;
            ar[5, 6].istarget = true;


            ar[0, 0].iswall = true;
            ar[0, 1].iswall = true;
            ar[0, 2].iswall = true;
            ar[0, 3].iswall = true;
            ar[0, 4].iswall = true;
            ar[0, 5].iswall = true;
            ar[0, 6].iswall = true;
            ar[0, 7].iswall = true;
            ar[0, 8].iswall = true;
            ar[0, 9].iswall = true;

            ar[3, 3].iswall = true;
            ar[4, 3].iswall = true;
            ar[5, 3].iswall = true;
            ar[6, 3].iswall = true;

            ar[3, 5].iswall = true;
            ar[4, 5].iswall = true;
            ar[5, 5].iswall = true;
            ar[6, 5].iswall = true;

            ar[1, 3].iswall = true;
            ar[1, 4].iswall = true;
            ar[1, 5].iswall = true;
            ar[1, 6].iswall = true;

            ar[8, 3].iswall = true;
            ar[8, 4].iswall = true;
            ar[8, 5].iswall = true;



            ar[3, 7].iswall = true;
            ar[4, 7].iswall = true;
            ar[5, 7].iswall = true;
            ar[6, 7].iswall = true;

            ar[3, 1].iswall = true;
            ar[4, 1].iswall = true;
            ar[5, 1].iswall = true;
            ar[6, 1].iswall = true;


            ar[1, 0].iswall = true;
            ar[2, 0].iswall = true;
            ar[3, 0].iswall = true;
            ar[4, 0].iswall = true;
            ar[5, 0].iswall = true;
            ar[6, 0].iswall = true;
            ar[7, 0].iswall = true;
            ar[8, 0].iswall = true;
            ar[9, 0].iswall = true;

            ar[9, 1].iswall = true;
            ar[9, 2].iswall = true;
            ar[9, 3].iswall = true;
            ar[9, 4].iswall = true;
            ar[9, 5].iswall = true;
            ar[9, 6].iswall = true;
            ar[9, 7].iswall = true;
            ar[9, 8].iswall = true;
            ar[9, 9].iswall = true;

            ar[1, 9].iswall = true;
            ar[2, 9].iswall = true;
            ar[3, 9].iswall = true;
            ar[4, 9].iswall = true;
            ar[5, 9].iswall = true;
            ar[6, 9].iswall = true;
            ar[7, 9].iswall = true;
            ar[8, 9].iswall = true;
            ar[9, 9].iswall = true;


            m = new Sokoban(1, 1);

            boxA = new Crate(4, 4, ar);
            boxB = new Crate(8, 6, ar);
            boxC = new Crate(2, 5, ar);
        }

        public void Draw()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Wall c in ar)
            {
                if (c.top == boxA.T && c.left == boxA.L)
                {
                    flowLayoutPanel1.Controls.Add(pictureBox3);
                }
                else if (c.top == boxB.T && c.left == boxB.L)
                {
                    flowLayoutPanel1.Controls.Add(pictureBox4);
                }
                else if (c.top == boxC.T && c.left == boxC.L)
                {
                    flowLayoutPanel1.Controls.Add(pictureBox5);
                }


                else if (c.left == m.L && c.top == m.T)
                {
                    flowLayoutPanel1.Controls.Add(pictureBox2);
                }

                else
                {
                    Panel panel1 = new Panel();


                    panel1.BackColor = System.Drawing.Color.SeaGreen;
                    if (c.istarget)
                        panel1.BackColor = System.Drawing.Color.FromArgb(255, 255, 128);

                    if (c.iswall)
                        panel1.BackColor = System.Drawing.Color.Black;
                        panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        panel1.Location = new System.Drawing.Point(0, 0);
                        panel1.Margin = new System.Windows.Forms.Padding(0);
                        panel1.Size = new System.Drawing.Size(50, 50);

                    flowLayoutPanel1.Controls.Add(panel1);
                }
            }
            label2.Text = mov.ToString();
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)

        {
            if (mov > 0)
            {

                if (e.KeyCode == Keys.Left)
                {
                    mov--;
                    if (ar[m.T, m.L - 1].iswall)
                    {

                    }
                    else if (m.T == boxA.T && m.L - 1 == boxA.L)
                    {
                        bool res = boxA.move("R");
                        if (res)
                            m.L--;

                    }
                    else if (m.T == boxB.T && m.L - 1 == boxB.L)
                    {
                        bool res = boxB.move("R");
                        if (res)
                            m.L--;

                    }
                    else if (m.T == boxC.T && m.L - 1 == boxC.L)
                    {
                        bool res = boxC.move("R");
                        if (res)
                            m.L--;

                    }


                    else { m.L--; }



                }
                else if (e.KeyCode == Keys.Right)
                {
                    mov--;
                    if (ar[m.T, m.L + 1].iswall)
                    {

                    }
                    else if (m.T == boxA.T && m.L + 1 == boxA.L)
                    {
                        bool res = boxA.move("L");
                        if (res)
                            m.L++;

                    }
                    else if (m.T == boxB.T && m.L + 1 == boxB.L)
                    {
                        bool res = boxB.move("L");
                        if (res)
                            m.L++;

                    }
                    else if (m.T == boxC.T && m.L + 1 == boxC.L)
                    {
                        bool res = boxC.move("L");
                        if (res)
                            m.L++;

                    }
                    else { m.L++; }

                }
                else if (e.KeyCode == Keys.Up)
                {
                    mov--;
                    if (ar[m.T - 1, m.L].iswall)
                    {

                    }
                    else if (m.T - 1 == boxA.T && m.L == boxA.L)
                    {
                        bool res = boxA.move("T");
                        if (res)
                            m.T--;

                    }
                    else if (m.T - 1 == boxB.T && m.L == boxB.L)
                    {
                        bool res = boxB.move("T");
                        if (res)
                            m.T--;

                    }
                    else if (m.T - 1 == boxC.T && m.L == boxC.L)
                    {
                        bool res = boxC.move("T");
                        if (res)
                            m.T--;

                    }
                    else { m.T--; }

                }
                else if (e.KeyCode == Keys.Down)
                {
                    mov--;
                    if (ar[m.T + 1, m.L].iswall)
                    {

                    }
                    else if (m.T + 1 == boxA.T && m.L == boxA.L)
                    {
                        bool res = boxA.move("D");
                        if (res)
                            m.T++;

                    }
                    else if (m.T + 1 == boxB.T && m.L == boxB.L)
                    {
                        bool res = boxB.move("D");
                        if (res)
                            m.T++;

                    }
                    else if (m.T + 1 == boxC.T && m.L == boxC.L)
                    {
                        bool res = boxC.move("D");
                        if (res)
                            m.T++;

                    }
                    else { m.T++; }

                }
            }
            else
            {
                string message = "Number of moves exceded! Do you wish to try again";
                string title = "Level Failed";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    mov = 70;
                    Init();
                    Draw();
                }
                else
                {
                    new Levels().Show();
                    this.Close();
                }
            }
            Draw();
            check_win();
        }


        public void check_win()
        {
            if (ar[boxA.T, boxA.L].istarget && ar[boxB.T, boxB.L].istarget && ar[boxC.T, boxC.L].istarget)
            {
                string message = "Go to Level 05";
                string title = "Level 04 Completed";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    new Level5().Show();
                    this.Close();
                }
                else
                {
                    new Levels().Show();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mov = 70;
            Init();
            Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                {
                    string message = "Are you sure you want to exit ?";
                    string title = "Exit Level";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        new Levels().Show();
                        this.Close();

                    }
                    else
                    {


                    }
                }

            }
        }
    }
}
