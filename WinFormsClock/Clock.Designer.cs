namespace WinFormsClock
{
    partial class Clock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Argentina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mexico = new System.Windows.Forms.Label();
            this.Peru = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DS-Digital", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "19:38:12";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Argentina
            // 
            this.Argentina.AutoSize = true;
            this.Argentina.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Argentina.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Argentina.Location = new System.Drawing.Point(12, 9);
            this.Argentina.Name = "Argentina";
            this.Argentina.Size = new System.Drawing.Size(83, 19);
            this.Argentina.TabIndex = 1;
            this.Argentina.Text = "Argentina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DS-Digital", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "19:38:12";
            // 
            // Mexico
            // 
            this.Mexico.AutoSize = true;
            this.Mexico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mexico.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Mexico.Location = new System.Drawing.Point(12, 80);
            this.Mexico.Name = "Mexico";
            this.Mexico.Size = new System.Drawing.Size(63, 19);
            this.Mexico.TabIndex = 3;
            this.Mexico.Text = "Mexico";
            this.Mexico.Click += new System.EventHandler(this.label3_Click);
            // 
            // Peru
            // 
            this.Peru.AutoSize = true;
            this.Peru.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Peru.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Peru.Location = new System.Drawing.Point(12, 151);
            this.Peru.Name = "Peru";
            this.Peru.Size = new System.Drawing.Size(135, 19);
            this.Peru.TabIndex = 4;
            this.Peru.Text = "Peru y Colombia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DS-Digital", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "19:38:12";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(242, 233);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Peru);
            this.Controls.Add(this.Mexico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Argentina);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("DS-Digital", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clock";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reloj";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Argentina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mexico;
        private System.Windows.Forms.Label Peru;
        private System.Windows.Forms.Label label3;
    }
}
