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
    public partial class Level2 : Form
    {
        int mov = 40;
        Wall[,] ar = new Wall[10, 10];

        Sokoban m;
        Crate Box1;
        Crate Box2;
        Crate Box3;

        public Level2()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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

            ar[2, 2].istarget = true;
            ar[5, 8].istarget = true;
            ar[7, 2].istarget = true;


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

            ar[3, 0].iswall = true;
            ar[3, 1].iswall = true;
            ar[3, 2].iswall = true;
            ar[3, 3].iswall = true;
            ar[3, 4].iswall = true;

            ar[6, 5].iswall = true;
            ar[6, 6].iswall = true;
            ar[6, 7].iswall = true;
            ar[6, 8].iswall = true;


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

            Box1 = new Crate(4, 2, ar);
            Box2 = new Crate(3, 6, ar);
            Box3 = new Crate(6, 7, ar);

        }

        public void Draw()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Wall c in ar)
            {
                if (c.top == Box1.T && c.left == Box1.L)
                {
                    flowLayoutPanel1.Controls.Add(pictureBox2);
                }
                else if (c.top == Box2.T && c.left == Box2.L)
                {
                    flowLayoutPanel1.Controls.Add(pictureBox3);
                }
                else if (c.top == Box3.T && c.left == Box3.L)
                {
                    flowLayoutPanel1.Controls.Add(pictureBox4);
                }



                else if (c.left == m.L && c.top == m.T)
                {
                    flowLayoutPanel1.Controls.Add(pictureBox5);
                }
                else
                {
                    Panel panel1 = new Panel();


                    panel1.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                    if (c.istarget)
                        panel1.BackColor = System.Drawing.Color.PaleGreen;

                    if (c.iswall)
                        panel1.BackColor = System.Drawing.Color.CadetBlue;
                        panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        panel1.Location = new System.Drawing.Point(0, 0);
                        panel1.Margin = new System.Windows.Forms.Padding(0);
                        panel1.Size = new System.Drawing.Size(50, 50);

                    flowLayoutPanel1.Controls.Add(panel1);
                }
            }
            label2.Text = mov.ToString();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (mov > 0)
            {
                if (e.KeyCode == Keys.Left)
                {
                    mov--;
                    if (ar[m.T, m.L - 1].iswall)
                    {

                    }
                    else if (m.T == Box1.T && m.L - 1 == Box1.L)
                    {
                        bool res = Box1.move("R");
                        if (res)
                            m.L--;

                    }
                    else if (m.T == Box2.T && m.L - 1 == Box2.L)
                    {
                        bool res = Box2.move("R");
                        if (res)
                            m.L--;

                    }
                    else if (m.T == Box3.T && m.L - 1 == Box3.L)
                    {
                        bool res = Box3.move("R");
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
                    else if (m.T == Box1.T && m.L + 1 == Box1.L)
                    {
                        bool res = Box1.move("L");
                        if (res)
                            m.L++;

                    }
                    else if (m.T == Box2.T && m.L + 1 == Box2.L)
                    {
                        bool res = Box2.move("L");
                        if (res)
                            m.L++;

                    }
                    else if (m.T == Box3.T && m.L + 1 == Box3.L)
                    {
                        bool res = Box3.move("L");
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
                    else if (m.T - 1 == Box1.T && m.L == Box1.L)
                    {
                        bool res = Box1.move("T");
                        if (res)
                            m.T--;

                    }
                    else if (m.T - 1 == Box2.T && m.L == Box2.L)
                    {
                        bool res = Box2.move("T");
                        if (res)
                            m.T--;

                    }
                    else if (m.T - 1 == Box3.T && m.L == Box3.L)
                    {
                        bool res = Box3.move("T");
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
                    else if (m.T + 1 == Box1.T && m.L == Box1.L)
                    {
                        bool res = Box1.move("D");
                        if (res)
                            m.T++;

                    }
                    else if (m.T + 1 == Box2.T && m.L == Box2.L)
                    {
                        bool res = Box2.move("D");
                        if (res)
                            m.T++;

                    }
                    else if (m.T + 1 == Box3.T && m.L == Box3.L)
                    {
                        bool res = Box3.move("D");
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
                    mov = 40;
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
            if (ar[Box1.T, Box1.L].istarget && ar[Box2.T, Box2.L].istarget && ar[Box3.T, Box3.L].istarget)
            {
                string message = "Go to Level 03";
                string title = "Level 02 Completed";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    new Level3().Show();
                }
                else
                {
                    new Levels().Show();
                    this.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mov = 40;
            Init();
            Draw();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            mov = 40;
            Init();
            Draw();
        }
    }
}
