using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TheVoicesAreGettingLouder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            VoicesOfTheFonts(false);

            if (!File.Exists(@"\My Documents\AJEnvironment\Config.txt"))
            {
                newEnv();
            }
            else
            {
                ReadSettingsFile();
            }
            FLUTdirDisp.Text = LUTsaveLoc;
            EntrSavDir.Text = EntrySaveLoc;
        }
        //FirstTimeThreadRunning
        public static bool FirstTimeRunning = false;
        public static bool ScreensaverRunning = false;
        //Save file location
        string fileName;
        string selectedFileName;
        bool marchEnable = true;
        bool ToggleFontCipher = true;
        //Environment Settings
        public static string LUTsaveLoc = "";
        public static string EntrySaveLoc = "";

        private void newEnv()
        {
            MessageBox.Show("New start detected. Creating environment files.");
            try
            {
                Directory.CreateDirectory(@"\My Documents\AJEnvironment\");
                Directory.CreateDirectory(@"\My Documents\AJEnvironment\FLUTs\");
                LUTsaveLoc = @"\My Documents\AJEnvironment\FLUTs\";
                Directory.CreateDirectory(@"\My Documents\AJEnvironment\CFonts\");
                Directory.CreateDirectory(@"\My Documents\AJEnvironment\Entries\");
                EntrySaveLoc = @"\My Documents\AJEnvironment\Entries\";
                using (StreamWriter sw = File.CreateText(@"\My Documents\AJEnvironment\Config.txt"))
                {
                    sw.WriteLine("Settings:");
                    sw.WriteLine("LUTsaveloc:" + LUTsaveLoc);
                    sw.WriteLine("Entrsaveloc:" + EntrySaveLoc);
                }
                MessageBox.Show("New files created succesfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not create files!" + ex.Message);
            }
        }

        private void ReadSettingsFile()
        {
            string SettingsFileDump = FileReadText(@"\My Documents\AJEnvironment\Config.txt");
            int pos = SettingsFileDump.IndexOf("LUTsaveloc:");
            if (pos != -1)
            {
                for (int i = pos + 11; char.IsLetterOrDigit(SettingsFileDump[i]) || (SettingsFileDump[i] == '\\') || (SettingsFileDump[i] == ' '); i++)
                {
                    LUTsaveLoc = LUTsaveLoc + SettingsFileDump[i];
                }
                pos = SettingsFileDump.IndexOf("Entrsaveloc:");
                for (int i = pos + 12; char.IsLetterOrDigit(SettingsFileDump[i]) || (SettingsFileDump[i] == '\\') || (SettingsFileDump[i] == ' '); i++)
                {
                    EntrySaveLoc = EntrySaveLoc + SettingsFileDump[i];
                }
                FLUTdirDisp.Text = LUTsaveLoc;
                EntrSavDir.Text = EntrySaveLoc;
                //MessageBox.Show(LUTsaveLoc + " " + EntrySaveLoc);
            }
            else
            {
                MessageBox.Show("Cannot read settings file! Program will now re-create the files");
                newEnv();
            }
        }

        private void UpdateSettingsPage()
        {
            using (StreamWriter sw = File.CreateText(@"\My Documents\AJEnvironment\Config.txt"))
            {
                sw.WriteLine("Settings:");
                sw.WriteLine("LUTsaveloc:" +LUTsaveLoc);
                sw.WriteLine("Entrsaveloc:" + EntrySaveLoc);
            }
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (toolBar1.Buttons.IndexOf(e.Button))
            {
                case 0://Open load dialog
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.Filter = "All Files|*.*";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        selectedFileName = openFileDialog1.FileName;
                        FileReadText(selectedFileName, textBox1);
                    }
                    break;
                case 1://Open timers
                    MessageBox.Show("Timers");
                    break;
                case 2://Open screensaver
                    ScreensaverRunning = true;
                    using (TripBalls msg = new TripBalls())
            {
                msg.ShowDialog();
            }
                    break;
                case 3://Open save dialog
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Text Files|*.txt";
                    saveFileDialog1.InitialDirectory = @"C:\";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        fileName = saveFileDialog1.FileName;
                        // Here you can save your file using the fileName
                        FileWriteText(fileName, textBox1);
                        MessageBox.Show("File saved at: " + fileName);
                    }
                    break;
                case 4:
                    //Open load dialog for appending
                    OpenFileDialog openFileDialog2 = new OpenFileDialog();
                    openFileDialog2.Filter = "Text Files|*.txt";
                    if (openFileDialog2.ShowDialog() == DialogResult.OK)
                    {
                        selectedFileName = openFileDialog2.FileName;
                        FileAppendText(selectedFileName, textBox1);
                    }
                    break;
                case 5:
                    // Open journal font LUT manager
                    using (FontLUTProcessor LUT = new FontLUTProcessor())
                    {
                        LUT.ShowDialog();
                    }
                break;
                case 6://MarchToggle
                    if (!ToggleFontCipher)
                    {
                        VoicesOfTheFonts(true);
                    }
                    else
                    {
                        VoicesOfTheFonts(false);
                    }
                    break;
            }
        }
        public void FileReadText(string Path, TextBox TB)
        {
            using (StreamReader sr = new StreamReader(Path))
            {
                string content = sr.ReadToEnd();
                TB.Text = content;
            }  
        }
        public string FileReadText(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }
        public void FileWriteText(string Path,TextBox TB )
        {
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.WriteLine(TB.Text);
            }
        }
        public void FileAppendText(string Path, TextBox TB)
        {
            using (StreamWriter sw = File.AppendText(Path))
            {
                sw.WriteLine(TB.Text);
            }
        }
        public void msgbox1()
        {
            MessageBox.Show("A");
        }
        public void msgbox2()
        {
            MessageBox.Show("B");
        }

        private void VoicesOfTheFonts(bool Option)
        {
            if (marchEnable)
            {
                if (Option)
                {
                    textBox1.Font = new Font("Honkai: Star Rail cipher", 14, FontStyle.Bold);
                    textBox2.Font = new Font("Honkai: Star Rail cipher", 14, FontStyle.Bold);
                    label1.Font = new Font("Honkai: Star Rail cipher", 14, FontStyle.Regular);
                    ToggleFontCipher = true;
                }
                else
                {
                    textBox1.Font = new Font("Tahoma", 12, FontStyle.Regular);
                    textBox2.Font = new Font("Tahoma", 12, FontStyle.Regular);
                    label1.Font = new Font("Tahoma", 12, FontStyle.Regular);
                    ToggleFontCipher = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ActiveJournalSystem AJS = new ActiveJournalSystem()){
                AJS.ShowDialog();
            }
        }

        private void ChangeFLUTDir_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.FileName = "AJEnvironment";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LUTsaveLoc = saveFileDialog1.FileName;
                // Here you can save your file using the fileName
                Directory.CreateDirectory(LUTsaveLoc);
                Directory.CreateDirectory(LUTsaveLoc + @"\FLUTs\");
                MessageBox.Show("New font lookup tables will be saved at: " + LUTsaveLoc);
            }
            FLUTdirDisp.Text = LUTsaveLoc;
            UpdateSettingsPage();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.FileName = "AJEnvironment";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                EntrySaveLoc = saveFileDialog1.FileName;
                // Here you can save your file using the fileName
                Directory.CreateDirectory(EntrySaveLoc);
                Directory.CreateDirectory(EntrySaveLoc + @"\Entries\");
                MessageBox.Show("New entries will be saved at: " + EntrySaveLoc);
            }
            EntrSavDir.Text = EntrySaveLoc;
            UpdateSettingsPage();
        }

    }
}