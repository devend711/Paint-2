namespace Paint2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.shapePanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.penWidthBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fillColorBox = new System.Windows.Forms.ListBox();
            this.outlineCheckBox = new System.Windows.Forms.CheckBox();
            this.fillCheckBox = new System.Windows.Forms.CheckBox();
            this.outlineColorBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.shapePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(7, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Line";
            // 
            // shapePanel
            // 
            this.shapePanel.BackColor = System.Drawing.SystemColors.Window;
            this.shapePanel.Controls.Add(this.textBox1);
            this.shapePanel.Controls.Add(this.radioButton4);
            this.shapePanel.Controls.Add(this.radioButton3);
            this.shapePanel.Controls.Add(this.radioButton2);
            this.shapePanel.Controls.Add(this.radioButton1);
            this.shapePanel.Location = new System.Drawing.Point(12, 27);
            this.shapePanel.Name = "shapePanel";
            this.shapePanel.Size = new System.Drawing.Size(114, 156);
            this.shapePanel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 43);
            this.textBox1.TabIndex = 11;
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(7, 64);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Text";
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(7, 44);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Ellipse";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(7, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Rectangle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.penWidthBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.fillColorBox);
            this.panel2.Controls.Add(this.outlineCheckBox);
            this.panel2.Controls.Add(this.fillCheckBox);
            this.panel2.Controls.Add(this.outlineColorBox);
            this.panel2.Controls.Add(this.shapePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 193);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Shape";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Outline Width";
            // 
            // penWidthBox
            // 
            this.penWidthBox.FormattingEnabled = true;
            this.penWidthBox.Items.AddRange(new object[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10});
            this.penWidthBox.Location = new System.Drawing.Point(322, 27);
            this.penWidthBox.Name = "penWidthBox";
            this.penWidthBox.Size = new System.Drawing.Size(120, 134);
            this.penWidthBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Outline Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fill Color";
            // 
            // fillColorBox
            // 
            this.fillColorBox.FormattingEnabled = true;
            this.fillColorBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.fillColorBox.Location = new System.Drawing.Point(226, 27);
            this.fillColorBox.Name = "fillColorBox";
            this.fillColorBox.Size = new System.Drawing.Size(90, 82);
            this.fillColorBox.TabIndex = 5;
            // 
            // outlineCheckBox
            // 
            this.outlineCheckBox.AutoSize = true;
            this.outlineCheckBox.Location = new System.Drawing.Point(226, 144);
            this.outlineCheckBox.Name = "outlineCheckBox";
            this.outlineCheckBox.Size = new System.Drawing.Size(59, 17);
            this.outlineCheckBox.TabIndex = 4;
            this.outlineCheckBox.Text = "Outline";
            this.outlineCheckBox.UseVisualStyleBackColor = true;
            this.outlineCheckBox.CheckedChanged += new System.EventHandler(this.outlineCheckBox_CheckedChanged);
            // 
            // fillCheckBox
            // 
            this.fillCheckBox.AutoSize = true;
            this.fillCheckBox.Location = new System.Drawing.Point(226, 121);
            this.fillCheckBox.Name = "fillCheckBox";
            this.fillCheckBox.Size = new System.Drawing.Size(38, 17);
            this.fillCheckBox.TabIndex = 3;
            this.fillCheckBox.Text = "Fill";
            this.fillCheckBox.UseVisualStyleBackColor = true;
            this.fillCheckBox.CheckedChanged += new System.EventHandler(this.fillCheckBox_CheckedChanged);
            // 
            // outlineColorBox
            // 
            this.outlineColorBox.FormattingEnabled = true;
            this.outlineColorBox.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.outlineColorBox.Location = new System.Drawing.Point(132, 27);
            this.outlineColorBox.Name = "outlineColorBox";
            this.outlineColorBox.Size = new System.Drawing.Size(88, 82);
            this.outlineColorBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 267);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint 2 - Deven Dayal";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.shapePanel.ResumeLayout(false);
            this.shapePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel shapePanel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ListBox outlineColorBox;
        private System.Windows.Forms.CheckBox outlineCheckBox;
        private System.Windows.Forms.CheckBox fillCheckBox;
        private System.Windows.Forms.ListBox fillColorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox penWidthBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

