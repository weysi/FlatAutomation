namespace FlatAutomation
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiderler = new System.Windows.Forms.Button();
            this.btnGelirler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(200, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "APARTMAN OTOMASYOUNU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGiderler
            // 
            this.btnGiderler.Location = new System.Drawing.Point(153, 159);
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.Size = new System.Drawing.Size(94, 68);
            this.btnGiderler.TabIndex = 1;
            this.btnGiderler.Text = "Giderler";
            this.btnGiderler.UseVisualStyleBackColor = true;
            this.btnGiderler.Click += new System.EventHandler(this.btnGiderler_Click);
            // 
            // btnGelirler
            // 
            this.btnGelirler.Location = new System.Drawing.Point(266, 159);
            this.btnGelirler.Name = "btnGelirler";
            this.btnGelirler.Size = new System.Drawing.Size(150, 68);
            this.btnGelirler.TabIndex = 2;
            this.btnGelirler.Text = "Gelirler";
            this.btnGelirler.UseVisualStyleBackColor = true;
            this.btnGelirler.Click += new System.EventHandler(this.btnGelirler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 365);
            this.Controls.Add(this.btnGelirler);
            this.Controls.Add(this.btnGiderler);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiderler;
        private System.Windows.Forms.Button btnGelirler;
    }
}

