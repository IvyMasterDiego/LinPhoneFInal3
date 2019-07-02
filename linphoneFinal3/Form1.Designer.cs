namespace linphoneFinal3
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
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnColgar = new System.Windows.Forms.Button();
            this.lblConect = new System.Windows.Forms.Label();
            this.lblunheard = new System.Windows.Forms.Label();
            this.lblBusy = new System.Windows.Forms.Label();
            this.lblDisconect = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(423, 12);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(75, 54);
            this.btnLlamar.TabIndex = 0;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            // 
            // btnColgar
            // 
            this.btnColgar.Location = new System.Drawing.Point(423, 74);
            this.btnColgar.Name = "btnColgar";
            this.btnColgar.Size = new System.Drawing.Size(75, 54);
            this.btnColgar.TabIndex = 1;
            this.btnColgar.Text = "Colgar";
            this.btnColgar.UseVisualStyleBackColor = true;
            // 
            // lblConect
            // 
            this.lblConect.Location = new System.Drawing.Point(-1, 105);
            this.lblConect.Name = "lblConect";
            this.lblConect.Size = new System.Drawing.Size(100, 23);
            this.lblConect.TabIndex = 2;
            this.lblConect.Text = "Conectado";
            this.lblConect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblunheard
            // 
            this.lblunheard.Location = new System.Drawing.Point(317, 105);
            this.lblunheard.Name = "lblunheard";
            this.lblunheard.Size = new System.Drawing.Size(100, 23);
            this.lblunheard.TabIndex = 3;
            this.lblunheard.Text = "Ignorado";
            this.lblunheard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBusy
            // 
            this.lblBusy.Location = new System.Drawing.Point(211, 105);
            this.lblBusy.Name = "lblBusy";
            this.lblBusy.Size = new System.Drawing.Size(100, 23);
            this.lblBusy.TabIndex = 4;
            this.lblBusy.Text = "Ocupado";
            this.lblBusy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisconect
            // 
            this.lblDisconect.Location = new System.Drawing.Point(105, 105);
            this.lblDisconect.Name = "lblDisconect";
            this.lblDisconect.Size = new System.Drawing.Size(100, 23);
            this.lblDisconect.TabIndex = 5;
            this.lblDisconect.Text = "Desconectado";
            this.lblDisconect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisconect.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 156);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDisconect);
            this.Controls.Add(this.lblBusy);
            this.Controls.Add(this.lblunheard);
            this.Controls.Add(this.lblConect);
            this.Controls.Add(this.btnColgar);
            this.Controls.Add(this.btnLlamar);
            this.Name = "Form1";
            this.Text = "SoftPhone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnColgar;
        private System.Windows.Forms.Label lblConect;
        private System.Windows.Forms.Label lblunheard;
        private System.Windows.Forms.Label lblBusy;
        private System.Windows.Forms.Label lblDisconect;
        private System.Windows.Forms.TextBox textBox1;
    }
}

