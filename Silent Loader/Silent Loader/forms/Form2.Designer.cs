namespace Silent_Loader
{
    partial class Form2
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
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneElipse2 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneProgressBar1 = new Siticone.UI.WinForms.SiticoneProgressBar();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneElipse3 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticonePanel1.Controls.Add(this.siticoneButton2);
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
            this.siticonePanel1.Controls.Add(this.siticoneLabel1);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(801, 47);
            this.siticonePanel1.TabIndex = 1;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(695, 0);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(50, 47);
            this.siticoneButton2.TabIndex = 2;
            this.siticoneButton2.Text = "-";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(751, 0);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(50, 47);
            this.siticoneButton1.TabIndex = 1;
            this.siticoneButton1.Text = "X";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel1.Location = new System.Drawing.Point(3, 3);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(152, 39);
            this.siticoneLabel1.TabIndex = 0;
            this.siticoneLabel1.Text = "Silent Loader";
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this.siticoneButton1;
            // 
            // siticoneElipse2
            // 
            this.siticoneElipse2.TargetControl = this.siticoneButton2;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.siticoneLabel1;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.siticonePanel1;
            // 
            // siticoneProgressBar1
            // 
            this.siticoneProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.siticoneProgressBar1.Location = new System.Drawing.Point(238, 209);
            this.siticoneProgressBar1.Name = "siticoneProgressBar1";
            this.siticoneProgressBar1.ShadowDecoration.Parent = this.siticoneProgressBar1;
            this.siticoneProgressBar1.ShowPercentage = true;
            this.siticoneProgressBar1.Size = new System.Drawing.Size(300, 30);
            this.siticoneProgressBar1.TabIndex = 2;
            this.siticoneProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel2.Location = new System.Drawing.Point(278, 173);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(225, 30);
            this.siticoneLabel2.TabIndex = 3;
            this.siticoneLabel2.Text = "Please wait until done. . .";
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(297, 254);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton3.TabIndex = 4;
            this.siticoneButton3.Text = "Launch!";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // siticoneElipse3
            // 
            this.siticoneElipse3.TargetControl = this.siticoneButton3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.siticoneProgressBar1);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse2;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private Siticone.UI.WinForms.SiticoneProgressBar siticoneProgressBar1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse3;
        private System.Windows.Forms.Timer timer1;
    }
}