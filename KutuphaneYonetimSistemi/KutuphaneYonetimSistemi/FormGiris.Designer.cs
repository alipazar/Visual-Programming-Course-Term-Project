namespace KutuphaneYonetimSistemi
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            buttonGiris = new Button();
            textBoxSifre = new TextBox();
            textBoxKullaniciAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(269, 195);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(93, 34);
            buttonGiris.TabIndex = 0;
            buttonGiris.Text = "Giris";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(269, 122);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(93, 23);
            textBoxSifre.TabIndex = 1;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(269, 72);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(93, 23);
            textBoxKullaniciAdi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 72);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 3;
            label1.Text = "Kullanici Adi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(118, 122);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 4;
            label2.Text = "Sifre :";
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(604, 355);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(textBoxSifre);
            Controls.Add(buttonGiris);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGiris";
            Text = "Kutuphane Yonetim Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGiris;
        private TextBox textBoxSifre;
        private TextBox textBoxKullaniciAdi;
        private Label label1;
        private Label label2;
    }
}
