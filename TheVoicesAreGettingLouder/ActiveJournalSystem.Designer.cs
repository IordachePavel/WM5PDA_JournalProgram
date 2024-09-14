namespace TheVoicesAreGettingLouder
{
    partial class ActiveJournalSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveJournalSystem));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.Tools = new System.Windows.Forms.TabControl();
            this.TextTools = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ColorPicker = new System.Windows.Forms.Button();
            this.ColorViewLive = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StickerPicker = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.AddSticker = new System.Windows.Forms.Button();
            this.Linkers = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ToEntryAdd = new System.Windows.Forms.Button();
            this.Pages = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.PictureBox();
            this.ColorSetter = new System.Windows.Forms.Panel();
            this.ColorValueReader = new System.Windows.Forms.Label();
            this.ColorPreview = new System.Windows.Forms.PictureBox();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.ColorUpdate = new System.Windows.Forms.Button();
            this.KeyboardRead = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.Tools.SuspendLayout();
            this.TextTools.SuspendLayout();
            this.StickerPicker.SuspendLayout();
            this.Linkers.SuspendLayout();
            this.Pages.SuspendLayout();
            this.ColorSetter.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Save entry";
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuItem3);
            this.menuItem2.MenuItems.Add(this.menuItem4);
            this.menuItem2.MenuItems.Add(this.menuItem5);
            this.menuItem2.MenuItems.Add(this.menuItem6);
            this.menuItem2.MenuItems.Add(this.menuItem7);
            this.menuItem2.Text = "Configuration";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Stickers";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Update LUTs";
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Quit without saving";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Input methods";
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "Test Purpose";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.TextTools);
            this.Tools.Controls.Add(this.StickerPicker);
            this.Tools.Controls.Add(this.Linkers);
            this.Tools.Controls.Add(this.Pages);
            this.Tools.Location = new System.Drawing.Point(0, 0);
            this.Tools.Name = "Tools";
            this.Tools.SelectedIndex = 0;
            this.Tools.Size = new System.Drawing.Size(240, 48);
            this.Tools.TabIndex = 0;
            // 
            // TextTools
            // 
            this.TextTools.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextTools.Controls.Add(this.comboBox2);
            this.TextTools.Controls.Add(this.ColorPicker);
            this.TextTools.Controls.Add(this.ColorViewLive);
            this.TextTools.Controls.Add(this.comboBox1);
            this.TextTools.Location = new System.Drawing.Point(0, 0);
            this.TextTools.Name = "TextTools";
            this.TextTools.Size = new System.Drawing.Size(240, 25);
            this.TextTools.Text = "Text";
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(109, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(52, 22);
            this.comboBox2.TabIndex = 3;
            // 
            // ColorPicker
            // 
            this.ColorPicker.Location = new System.Drawing.Point(167, 4);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(30, 20);
            this.ColorPicker.TabIndex = 2;
            this.ColorPicker.Text = "Col.";
            this.ColorPicker.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // ColorViewLive
            // 
            this.ColorViewLive.Location = new System.Drawing.Point(203, 3);
            this.ColorViewLive.Name = "ColorViewLive";
            this.ColorViewLive.ReadOnly = true;
            this.ColorViewLive.Size = new System.Drawing.Size(30, 21);
            this.ColorViewLive.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 22);
            this.comboBox1.TabIndex = 0;
            // 
            // StickerPicker
            // 
            this.StickerPicker.Controls.Add(this.comboBox3);
            this.StickerPicker.Controls.Add(this.AddSticker);
            this.StickerPicker.Location = new System.Drawing.Point(0, 0);
            this.StickerPicker.Name = "StickerPicker";
            this.StickerPicker.Size = new System.Drawing.Size(232, 22);
            this.StickerPicker.Text = "Sticker Picker";
            // 
            // comboBox3
            // 
            this.comboBox3.Location = new System.Drawing.Point(3, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(176, 22);
            this.comboBox3.TabIndex = 1;
            // 
            // AddSticker
            // 
            this.AddSticker.Location = new System.Drawing.Point(185, 3);
            this.AddSticker.Name = "AddSticker";
            this.AddSticker.Size = new System.Drawing.Size(48, 20);
            this.AddSticker.TabIndex = 0;
            this.AddSticker.Text = "Add";
            // 
            // Linkers
            // 
            this.Linkers.Controls.Add(this.button2);
            this.Linkers.Controls.Add(this.button1);
            this.Linkers.Controls.Add(this.ToEntryAdd);
            this.Linkers.Location = new System.Drawing.Point(0, 0);
            this.Linkers.Name = "Linkers";
            this.Linkers.Size = new System.Drawing.Size(232, 22);
            this.Linkers.Text = "Add links";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Section";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "To Image/File";
            // 
            // ToEntryAdd
            // 
            this.ToEntryAdd.Location = new System.Drawing.Point(0, 0);
            this.ToEntryAdd.Name = "ToEntryAdd";
            this.ToEntryAdd.Size = new System.Drawing.Size(66, 25);
            this.ToEntryAdd.TabIndex = 0;
            this.ToEntryAdd.Text = "To entry";
            // 
            // Pages
            // 
            this.Pages.Controls.Add(this.button4);
            this.Pages.Controls.Add(this.button3);
            this.Pages.Controls.Add(this.Back);
            this.Pages.Controls.Add(this.textBox2);
            this.Pages.Controls.Add(this.label1);
            this.Pages.Location = new System.Drawing.Point(0, 0);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(232, 22);
            this.Pages.Text = "Entry page";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 20);
            this.button4.TabIndex = 4;
            this.button4.Text = ">";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 20);
            this.button3.TabIndex = 3;
            this.button3.Text = "Go";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(138, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(23, 20);
            this.Back.TabIndex = 2;
            this.Back.Text = "<";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.Text = "Current page:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Display
            // 
            this.Display.Image = ((System.Drawing.Image)(resources.GetObject("Display.Image")));
            this.Display.Location = new System.Drawing.Point(0, 48);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(240, 246);
            this.Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // ColorSetter
            // 
            this.ColorSetter.Controls.Add(this.ColorValueReader);
            this.ColorSetter.Controls.Add(this.ColorPreview);
            this.ColorSetter.Controls.Add(this.BlueBar);
            this.ColorSetter.Controls.Add(this.GreenBar);
            this.ColorSetter.Controls.Add(this.RedBar);
            this.ColorSetter.Controls.Add(this.ColorUpdate);
            this.ColorSetter.Location = new System.Drawing.Point(3, 54);
            this.ColorSetter.Name = "ColorSetter";
            this.ColorSetter.Size = new System.Drawing.Size(161, 155);
            this.ColorSetter.Visible = false;
            // 
            // ColorValueReader
            // 
            this.ColorValueReader.Location = new System.Drawing.Point(3, 109);
            this.ColorValueReader.Name = "ColorValueReader";
            this.ColorValueReader.Size = new System.Drawing.Size(150, 20);
            this.ColorValueReader.Text = "R: 0 G: 0 B: 0";
            // 
            // ColorPreview
            // 
            this.ColorPreview.BackColor = System.Drawing.Color.Black;
            this.ColorPreview.Location = new System.Drawing.Point(109, 17);
            this.ColorPreview.Name = "ColorPreview";
            this.ColorPreview.Size = new System.Drawing.Size(44, 79);
            // 
            // BlueBar
            // 
            this.BlueBar.Location = new System.Drawing.Point(3, 69);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(100, 27);
            this.BlueBar.TabIndex = 4;
            this.BlueBar.ValueChanged += new System.EventHandler(this.BlueBar_ValueChanged);
            // 
            // GreenBar
            // 
            this.GreenBar.Location = new System.Drawing.Point(3, 36);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(100, 27);
            this.GreenBar.TabIndex = 3;
            this.GreenBar.ValueChanged += new System.EventHandler(this.GreenBar_ValueChanged);
            // 
            // RedBar
            // 
            this.RedBar.Location = new System.Drawing.Point(3, 3);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(100, 27);
            this.RedBar.TabIndex = 2;
            this.RedBar.ValueChanged += new System.EventHandler(this.RedBar_ValueChanged);
            // 
            // ColorUpdate
            // 
            this.ColorUpdate.Location = new System.Drawing.Point(3, 132);
            this.ColorUpdate.Name = "ColorUpdate";
            this.ColorUpdate.Size = new System.Drawing.Size(155, 20);
            this.ColorUpdate.TabIndex = 0;
            this.ColorUpdate.Text = "Set";
            this.ColorUpdate.Click += new System.EventHandler(this.ColorUpdate_Click);
            // 
            // ActiveJournalSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.ColorSetter);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Tools);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "ActiveJournalSystem";
            this.Text = "ActiveJournalSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Tools.ResumeLayout(false);
            this.TextTools.ResumeLayout(false);
            this.StickerPicker.ResumeLayout(false);
            this.Linkers.ResumeLayout(false);
            this.Pages.ResumeLayout(false);
            this.ColorSetter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.TabControl Tools;
        private System.Windows.Forms.TabPage TextTools;
        private System.Windows.Forms.TabPage StickerPicker;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage Linkers;
        private System.Windows.Forms.TabPage Pages;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button ColorPicker;
        private System.Windows.Forms.TextBox ColorViewLive;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button AddSticker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ToEntryAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Display;
        private System.Windows.Forms.Panel ColorSetter;
        private System.Windows.Forms.Label ColorValueReader;
        private System.Windows.Forms.PictureBox ColorPreview;
        private System.Windows.Forms.TrackBar BlueBar;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.Button ColorUpdate;
        private System.Windows.Forms.MenuItem menuItem7;
        private Microsoft.WindowsCE.Forms.InputPanel KeyboardRead;
    }
}