namespace CustomControlsUI
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
            this.progressBarCustom1 = new CustomControlsUI.ClassControls.ProgressBarCustom();
            this.buttonRadius1 = new CustomControlsUI.ClassControls.ButtonRadius();
            this.textboxCustom1 = new CustomControlsUI.UserControls.TextboxCustom();
            this.toggleButton1 = new CustomControlsUI.ClassControls.ToggleButton();
            this.datimePickerCustom1 = new CustomControlsUI.ClassControls.DatimePickerCustom();
            this.SuspendLayout();
            // 
            // progressBarCustom1
            // 
            this.progressBarCustom1.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progressBarCustom1.ChannelHeight = 6;
            this.progressBarCustom1.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progressBarCustom1.ForeColor = System.Drawing.Color.White;
            this.progressBarCustom1.Location = new System.Drawing.Point(69, 106);
            this.progressBarCustom1.Name = "progressBarCustom1";
            this.progressBarCustom1.ShowMaximun = false;
            this.progressBarCustom1.ShowValue = CustomControlsUI.ClassControls.TextPosition.Right;
            this.progressBarCustom1.Size = new System.Drawing.Size(319, 13);
            this.progressBarCustom1.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progressBarCustom1.SliderHeight = 6;
            this.progressBarCustom1.SymbolAfter = "";
            this.progressBarCustom1.SymbolBefore = "";
            this.progressBarCustom1.TabIndex = 2;
            // 
            // buttonRadius1
            // 
            this.buttonRadius1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonRadius1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonRadius1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRadius1.BorderRadius = 40;
            this.buttonRadius1.BorderSize = 0;
            this.buttonRadius1.FlatAppearance.BorderSize = 0;
            this.buttonRadius1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRadius1.ForeColor = System.Drawing.Color.White;
            this.buttonRadius1.Location = new System.Drawing.Point(238, 190);
            this.buttonRadius1.Name = "buttonRadius1";
            this.buttonRadius1.Size = new System.Drawing.Size(131, 40);
            this.buttonRadius1.TabIndex = 1;
            this.buttonRadius1.Text = "buttonRadius1";
            this.buttonRadius1.TextColor = System.Drawing.Color.White;
            this.buttonRadius1.UseVisualStyleBackColor = false;
            this.buttonRadius1.Click += new System.EventHandler(this.buttonRadius1_Click);
            // 
            // textboxCustom1
            // 
            this.textboxCustom1.BackColor = System.Drawing.SystemColors.Window;
            this.textboxCustom1.BoderFocusColor = System.Drawing.Color.HotPink;
            this.textboxCustom1.BoderRadius = 20;
            this.textboxCustom1.BoderSize = 1;
            this.textboxCustom1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxCustom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxCustom1.Location = new System.Drawing.Point(69, 60);
            this.textboxCustom1.Multiline = false;
            this.textboxCustom1.Name = "textboxCustom1";
            this.textboxCustom1.Padding = new System.Windows.Forms.Padding(7);
            this.textboxCustom1.PasswordChar = false;
            this.textboxCustom1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxCustom1.PlaceholderText = "fasdfasdf";
            this.textboxCustom1.Size = new System.Drawing.Size(322, 31);
            this.textboxCustom1.TabIndex = 0;
            this.textboxCustom1.UnderLineStyle = false;
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Location = new System.Drawing.Point(69, 208);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Red;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.PaleGreen;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(45, 22);
            this.toggleButton1.TabIndex = 3;
            this.toggleButton1.UseVisualStyleBackColor = true;
            // 
            // datimePickerCustom1
            // 
            this.datimePickerCustom1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datimePickerCustom1.BorderSize = 0;
            this.datimePickerCustom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datimePickerCustom1.Location = new System.Drawing.Point(69, 138);
            this.datimePickerCustom1.MinimumSize = new System.Drawing.Size(4, 35);
            this.datimePickerCustom1.Name = "datimePickerCustom1";
            this.datimePickerCustom1.Size = new System.Drawing.Size(319, 35);
            this.datimePickerCustom1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datimePickerCustom1.TabIndex = 4;
            this.datimePickerCustom1.TextColor = System.Drawing.Color.White;
            this.datimePickerCustom1.ValueChanged += new System.EventHandler(this.datimePickerCustom1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datimePickerCustom1);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.progressBarCustom1);
            this.Controls.Add(this.buttonRadius1);
            this.Controls.Add(this.textboxCustom1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.TextboxCustom textboxCustom1;
        private ClassControls.ButtonRadius buttonRadius1;
        private ClassControls.ProgressBarCustom progressBarCustom1;
        private ClassControls.ToggleButton toggleButton1;
        private ClassControls.DatimePickerCustom datimePickerCustom1;
    }
}

