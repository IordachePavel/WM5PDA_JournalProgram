using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheVoicesAreGettingLouder
{
    public partial class FontLUTProcessor : Form
    {

        public static string forbiddenChars = "./*?\\:;'|`~";

        public FontLUTProcessor()
        {
            InitializeComponent();
            LoadFonts();
        }

        private void LoadFonts()
        {
            string[] commonFonts = {"Courier New", "Tahoma", "Honkai: Star Rail cipher" };
            foreach (string fontName in commonFonts)
            {
                fontComboBox.Items.Add(fontName);
            }

            if (fontComboBox.Items.Count > 0)
            {
                fontComboBox.SelectedIndex = 0;
            }
        }

        private void ViewCharacter_Click(object sender, EventArgs e)
        {
            Bitmap Canvas = new Bitmap(100, 100);
            using (Pen pen = new Pen(Color.White))
            using (Graphics gfx = Graphics.FromImage(Canvas))
            {
                for (int i = 10; i < 80; i++)
                {
                    if (i % 2 == 1)
                    {
                        Canvas.SetPixel(10, i, Color.Orange);
                    }
                    else
                    {
                        Canvas.SetPixel(10, i, Color.White);
                    }
                }
                for (int i = 10; i < 80; i++)
                {
                    if (i % 2 == 1)
                    {
                        Canvas.SetPixel(i, 80, Color.Orange);
                    }
                    else
                    {
                        Canvas.SetPixel(i, 80, Color.White);
                    }
                }
                Brush whiteBrush = new SolidBrush(Color.White);
                Font Tfont;
                string Fsel = fontComboBox.SelectedItem as string;
                try
                {
                    Tfont = new Font(Fsel, Convert.ToInt32(textBox2.Text), FontStyle.Regular);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid font size parameter!");
                    Tfont = new Font(Fsel, 14, FontStyle.Regular);
                }
                SizeF CharDimensions = gfx.MeasureString(textBox1.Text,Tfont);
                gfx.DrawString(textBox1.Text,Tfont,whiteBrush,11,79-CharDimensions.Height);
                label4.Text = "Font: " + Tfont.Name + "\nCharacter dimensions (x,y): " + Convert.ToString(CharDimensions.Width) + "," + Convert.ToString(CharDimensions.Height) + "\nFont Size: " + Convert.ToString(Tfont.Size);
            }

            PreviewWindow.Invoke((Action)(() => PreviewWindow.Image = Canvas));
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            string fileName = "LUT_" + fontComboBox.SelectedItem as string;
            char[] t_filenamearray = fileName.ToCharArray();
           // MessageBox.Show(t_filenamearray.ToString());
            for (int i = 0; t_filenamearray.Length>i; i++)
            {
                if (forbiddenChars.Contains(t_filenamearray[i])) 
                t_filenamearray[i] = '_';
            }
            fileName = new string(t_filenamearray);
            //MessageBox.Show(fileName);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = fileName;
            saveFileDialog1.Filter = "Font Lookup Table|*.FLUT";
            saveFileDialog1.InitialDirectory = Form1.LUTsaveLoc;
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    Bitmap Canvas = new Bitmap(100, 100);
                    using (Pen pen = new Pen(Color.White))
                    using (Graphics gfx = Graphics.FromImage(Canvas))
                    {
                        //string LUTtext="";
                        SizeF CharDimensions;
                        string Fsel = fontComboBox.SelectedItem as string;
                        Font Tfont;
                        sw.WriteLine(fontComboBox.SelectedItem as string);
                        for (int j = 5; j < 20; j++)
                        {
                            sw.WriteLine("Size:" + Convert.ToString(j));
                            for (int i = 32; i < 126; i++)
                            {
                                Tfont = new Font(Fsel, j, FontStyle.Regular);
                                CharDimensions = gfx.MeasureString(Convert.ToString(Convert.ToChar(i)), Tfont);
                                sw.WriteLine(Convert.ToChar(i) + ": " + Convert.ToString(CharDimensions.Width) + "," + Convert.ToString(CharDimensions.Height));
                            }
                        }
                        MessageBox.Show("File saved at: " + saveFileDialog1.FileName);
                    }
                }
            }
            }
    }
}