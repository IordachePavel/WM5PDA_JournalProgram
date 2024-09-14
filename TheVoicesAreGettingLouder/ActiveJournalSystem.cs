using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenNETCF.Windows.Forms;

namespace TheVoicesAreGettingLouder
{
    public partial class ActiveJournalSystem : Form
    {
        bool ColorPickerShown = false;
        Color FontColor;
        Color OldColor;
        Color CurrentColor;
        byte[] PageMem = new byte[125000]; // A whole entry can be a maximum of 125KB
        byte[,] TextLayout = new byte[2,125000];//X and Y zises of chars
        List<char[,]> fLUT = new List<char[,]>();

        

        public ActiveJournalSystem()
        {
            InitializeComponent();
            ColorViewLive.BackColor = Color.Black;
            AllKeys allKeys = new AllKeys();
            allKeys.KeyDown += new KeyEventHandler(allKeys_KeyDown);

        }

        private void allKeys_KeyDown(object sender, KeyEventArgs e)
        {
            char[] joe=new char[5];
            joe[1]= e.KeyCode;
            string balls = new string(joe);
            MessageBox.Show(balls);
        }

        private void PrepFLUTs(string Name, string PATH)
        {

        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            if (!ColorPickerShown)
            {
                ColorPickerShown = true;
                ColorSetter.Show();
            }
            else
            {
                ColorSetter.Hide();
                ColorPickerShown = false;
            }
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RedBar_ValueChanged(object sender, EventArgs e)
        {
            FontColor = System.Drawing.Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value);
            ColorPreview.BackColor = FontColor;
            ColorValueReader.Text = "R: " + Convert.ToString(RedBar.Value) + " G: " + Convert.ToString(GreenBar.Value) + " B: " + Convert.ToString(BlueBar.Value);
        }

        private void GreenBar_ValueChanged(object sender, EventArgs e)
        {
            FontColor = System.Drawing.Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value);
            ColorPreview.BackColor = FontColor;
            ColorValueReader.Text = "R: " + Convert.ToString(RedBar.Value) + " G: " + Convert.ToString(GreenBar.Value) + " B: " + Convert.ToString(BlueBar.Value);
        }

        private void BlueBar_ValueChanged(object sender, EventArgs e)
        {
            FontColor = System.Drawing.Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value);
            ColorPreview.BackColor = FontColor;
            ColorValueReader.Text = "R: " + Convert.ToString(RedBar.Value) + " G: " + Convert.ToString(GreenBar.Value) + " B: " + Convert.ToString(BlueBar.Value);
        }

        private void ColorUpdate_Click(object sender, EventArgs e)
        {
            OldColor = CurrentColor;
            CurrentColor = FontColor;
            ColorViewLive.BackColor = CurrentColor;
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
        }

    }
}