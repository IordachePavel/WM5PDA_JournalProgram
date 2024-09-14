namespace TheVoicesAreGettingLouder
{
    partial class FontLUTProcessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontLUTProcessor));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PreviewWindow = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ViewCharacter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 268);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.fontComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ViewCharacter);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PreviewWindow);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 253);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Open LUT";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "New LUT";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.Text = "Character Preview:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 63);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // PreviewWindow
            // 
            this.PreviewWindow.BackColor = System.Drawing.Color.Black;
            this.PreviewWindow.Location = new System.Drawing.Point(14, 44);
            this.PreviewWindow.Name = "PreviewWindow";
            this.PreviewWindow.Size = new System.Drawing.Size(90, 90);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(119, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Character:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(119, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Size";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 5;
            // 
            // ViewCharacter
            // 
            this.ViewCharacter.Location = new System.Drawing.Point(14, 171);
            this.ViewCharacter.Name = "ViewCharacter";
            this.ViewCharacter.Size = new System.Drawing.Size(205, 20);
            this.ViewCharacter.TabIndex = 6;
            this.ViewCharacter.Text = "View Character";
            this.ViewCharacter.Click += new System.EventHandler(this.ViewCharacter_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(14, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 49);
            this.label4.Text = "label4";
            // 
            // fontComboBox
            // 
            this.fontComboBox.Location = new System.Drawing.Point(14, 143);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(205, 22);
            this.fontComboBox.TabIndex = 8;
            // 
            // FontLUTProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "FontLUTProcessor";
            this.Text = "FontLUTProcessor";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PreviewWindow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ViewCharacter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fontComboBox;

    }
}