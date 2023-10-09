namespace radyobuton4islem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbToplam = new System.Windows.Forms.RadioButton();
            this.rbCikarma = new System.Windows.Forms.RadioButton();
            this.rbCarpma = new System.Windows.Forms.RadioButton();
            this.rbBolme = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBolme);
            this.groupBox1.Controls.Add(this.rbCarpma);
            this.groupBox1.Controls.Add(this.rbCikarma);
            this.groupBox1.Controls.Add(this.rbToplam);
            this.groupBox1.Location = new System.Drawing.Point(49, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // rbToplam
            // 
            this.rbToplam.AutoSize = true;
            this.rbToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbToplam.Location = new System.Drawing.Point(6, 50);
            this.rbToplam.Name = "rbToplam";
            this.rbToplam.Size = new System.Drawing.Size(79, 24);
            this.rbToplam.TabIndex = 1;
            this.rbToplam.TabStop = true;
            this.rbToplam.Text = "Toplam";
            this.rbToplam.UseVisualStyleBackColor = true;
            // 
            // rbCikarma
            // 
            this.rbCikarma.AutoSize = true;
            this.rbCikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCikarma.Location = new System.Drawing.Point(113, 50);
            this.rbCikarma.Name = "rbCikarma";
            this.rbCikarma.Size = new System.Drawing.Size(85, 24);
            this.rbCikarma.TabIndex = 2;
            this.rbCikarma.TabStop = true;
            this.rbCikarma.Text = "Çıkarma";
            this.rbCikarma.UseVisualStyleBackColor = true;
            // 
            // rbCarpma
            // 
            this.rbCarpma.AutoSize = true;
            this.rbCarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCarpma.Location = new System.Drawing.Point(226, 50);
            this.rbCarpma.Name = "rbCarpma";
            this.rbCarpma.Size = new System.Drawing.Size(83, 24);
            this.rbCarpma.TabIndex = 3;
            this.rbCarpma.TabStop = true;
            this.rbCarpma.Text = "Çarpma";
            this.rbCarpma.UseVisualStyleBackColor = true;
            // 
            // rbBolme
            // 
            this.rbBolme.AutoSize = true;
            this.rbBolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBolme.Location = new System.Drawing.Point(349, 50);
            this.rbBolme.Name = "rbBolme";
            this.rbBolme.Size = new System.Drawing.Size(72, 24);
            this.rbBolme.TabIndex = 4;
            this.rbBolme.TabStop = true;
            this.rbBolme.Text = "Bölme";
            this.rbBolme.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı 1";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(121, 271);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 32);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSayi1
            // 
            this.txtSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi1.Location = new System.Drawing.Point(121, 207);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 26);
            this.txtSayi1.TabIndex = 3;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi2.Location = new System.Drawing.Point(121, 239);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 26);
            this.txtSayi2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sayı 2";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(253, 274);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(59, 20);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "Sonuç;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBolme;
        private System.Windows.Forms.RadioButton rbCarpma;
        private System.Windows.Forms.RadioButton rbCikarma;
        private System.Windows.Forms.RadioButton rbToplam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSonuc;
    }
}

