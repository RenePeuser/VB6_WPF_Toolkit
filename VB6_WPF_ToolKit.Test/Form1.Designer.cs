namespace VB6_WPF_ToolKit.Test
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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.wpfButtonControl1 = new VB6_WPF_Toolkit_ControlTemplates.Controls.WpfButtonControl();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.wpfImageControl1 = new VB6_WPF_Toolkit_ControlTemplates.Controls.WpfImageControl();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.wpfSliderControl1 = new VB6_WPF_Toolkit_ControlTemplates.Controls.WpfSliderControl();
            this.wpfRibbon1 = new VB6_WPF_Toolkit.Controls.WpfRibbon();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(38, 50);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(204, 70);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.wpfButtonControl1;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(38, 169);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(173, 83);
            this.elementHost2.TabIndex = 1;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.wpfImageControl1;
            // 
            // elementHost3
            // 
            this.elementHost3.Location = new System.Drawing.Point(263, 189);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(194, 63);
            this.elementHost3.TabIndex = 2;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.wpfSliderControl1;
            // 
            // wpfRibbon1
            // 
            this.wpfRibbon1.BackColor = System.Drawing.SystemColors.Control;
            this.wpfRibbon1.BackgroundColor = -2147483633;
            this.wpfRibbon1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wpfRibbon1.ForegroundColor = -2147483630;
            this.wpfRibbon1.Location = new System.Drawing.Point(38, 287);
            this.wpfRibbon1.Name = "wpfRibbon1";
            this.wpfRibbon1.Size = new System.Drawing.Size(309, 127);
            this.wpfRibbon1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 612);
            this.Controls.Add(this.wpfRibbon1);
            this.Controls.Add(this.elementHost3);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.elementHost1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private VB6_WPF_Toolkit_ControlTemplates.Controls.WpfButtonControl wpfButtonControl1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private VB6_WPF_Toolkit_ControlTemplates.Controls.WpfImageControl wpfImageControl1;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private VB6_WPF_Toolkit_ControlTemplates.Controls.WpfSliderControl wpfSliderControl1;
        private VB6_WPF_Toolkit.Controls.WpfRibbon wpfRibbon1;
    }
}

