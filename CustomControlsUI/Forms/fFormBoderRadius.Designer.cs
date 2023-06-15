namespace CustomControlsUI.Forms
{
    partial class fFormBoderRadius
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFormBoderRadius));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datimePickerCustom1 = new CustomControlsUI.ClassControls.DatimePickerCustom();
            this.toggleButton1 = new CustomControlsUI.ClassControls.ToggleButton();
            this.progressBarCustom1 = new CustomControlsUI.ClassControls.ProgressBarCustom();
            this.textboxCustom1 = new CustomControlsUI.UserControls.TextboxCustom();
            this.btnLoad = new CustomControlsUI.ClassControls.ButtonRadius();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // datimePickerCustom1
            // 
            this.datimePickerCustom1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datimePickerCustom1.BorderSize = 0;
            this.datimePickerCustom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datimePickerCustom1.Location = new System.Drawing.Point(243, 124);
            this.datimePickerCustom1.MinimumSize = new System.Drawing.Size(0, 35);
            this.datimePickerCustom1.Name = "datimePickerCustom1";
            this.datimePickerCustom1.Size = new System.Drawing.Size(200, 35);
            this.datimePickerCustom1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.datimePickerCustom1.TabIndex = 1;
            this.datimePickerCustom1.TextColor = System.Drawing.Color.White;
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.BackColor = System.Drawing.Color.OrangeRed;
            this.toggleButton1.Location = new System.Drawing.Point(243, 77);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(45, 22);
            this.toggleButton1.TabIndex = 2;
            this.toggleButton1.UseVisualStyleBackColor = false;
            this.toggleButton1.CheckedChanged += new System.EventHandler(this.toggleButton1_CheckedChanged);
            // 
            // progressBarCustom1
            // 
            this.progressBarCustom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.progressBarCustom1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(123)))), ((int)(((byte)(191)))));
            this.progressBarCustom1.ChannelHeight = 6;
            this.progressBarCustom1.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progressBarCustom1.ForeColor = System.Drawing.Color.White;
            this.progressBarCustom1.Location = new System.Drawing.Point(243, 24);
            this.progressBarCustom1.Name = "progressBarCustom1";
            this.progressBarCustom1.ShowMaximun = false;
            this.progressBarCustom1.ShowValue = CustomControlsUI.ClassControls.TextPosition.Right;
            this.progressBarCustom1.Size = new System.Drawing.Size(483, 23);
            this.progressBarCustom1.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progressBarCustom1.SliderHeight = 6;
            this.progressBarCustom1.SymbolAfter = "";
            this.progressBarCustom1.SymbolBefore = "";
            this.progressBarCustom1.TabIndex = 3;
            // 
            // textboxCustom1
            // 
            this.textboxCustom1.BackColor = System.Drawing.SystemColors.Window;
            this.textboxCustom1.BoderFocusColor = System.Drawing.Color.HotPink;
            this.textboxCustom1.BoderRadius = 0;
            this.textboxCustom1.BoderSize = 2;
            this.textboxCustom1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.textboxCustom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxCustom1.Location = new System.Drawing.Point(243, 182);
            this.textboxCustom1.Multiline = false;
            this.textboxCustom1.Name = "textboxCustom1";
            this.textboxCustom1.Padding = new System.Windows.Forms.Padding(7);
            this.textboxCustom1.PasswordChar = false;
            this.textboxCustom1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxCustom1.PlaceholderText = "";
            this.textboxCustom1.Size = new System.Drawing.Size(255, 31);
            this.textboxCustom1.TabIndex = 4;
            this.textboxCustom1.UnderLineStyle = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.btnLoad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(71)))), ((int)(((byte)(104)))));
            this.btnLoad.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLoad.BorderRadius = 30;
            this.btnLoad.BorderSize = 0;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(243, 233);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 40);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextColor = System.Drawing.Color.White;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 15);
            this.panel1.TabIndex = 6;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(123)))), ((int)(((byte)(191)))));
            this.pnlActive.Location = new System.Drawing.Point(0, 435);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(20, 15);
            this.pnlActive.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "%";
            // 
            // fFormBoderRadius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlActive);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.textboxCustom1);
            this.Controls.Add(this.progressBarCustom1);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.datimePickerCustom1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fFormBoderRadius";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fFormBoderRadius";
            this.Load += new System.EventHandler(this.fFormBoderRadius_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ClassControls.DatimePickerCustom datimePickerCustom1;
        private ClassControls.ToggleButton toggleButton1;
        private ClassControls.ProgressBarCustom progressBarCustom1;
        private UserControls.TextboxCustom textboxCustom1;
        private ClassControls.ButtonRadius btnLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}