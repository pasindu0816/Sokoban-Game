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
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Level1 ff = new Level1();
            ff.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Level2 ff = new Level2();
            ff.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Level3 ff = new Level3();
            ff.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Level4 ff = new Level4();
            ff.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Level5 ff = new Level5();
            ff.Show();
        }
    }
}
