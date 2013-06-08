using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using WMPLib;

namespace RomanTankonyv
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
            Player player = new Player();
            player.playSimpleSound("_www_fisierulmeu_ro__Desteapta_te_romane");

        }

        public void ClearButtons()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is Button)
                {
                    Controls.RemoveAt(i);
                    i--;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearButtons();
            this.BackgroundImage = Properties.Resources._4;
            
        }
    }
}
