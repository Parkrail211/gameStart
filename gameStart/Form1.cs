using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
//hi
namespace gameStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer buttonPlayer = new SoundPlayer(Properties.Resources.button);
            SoundPlayer beepPlayer = new SoundPlayer(Properties.Resources.beep);
            SoundPlayer babaBooeyPlayer = new SoundPlayer(Properties.Resources.babaBooey1);
            buttonPlayer.Play();

            startButton.Visible = false;
            Thread.Sleep(300);
            countDown.Visible = true;
            Refresh();
            beepPlayer.Play();

            Thread.Sleep(1000);
            countDown.Text = "2";
            Refresh();
            beepPlayer.Play();

            Thread.Sleep(1000);
            countDown.Text = "1";
            Refresh();
            beepPlayer.Play();

            Thread.Sleep(1000);
            countDown.Visible = false;
            this.BackColor = Color.ForestGreen;
            gameGo.Visible = true;
            babaBooeyPlayer.Play();
        }
    }
}
