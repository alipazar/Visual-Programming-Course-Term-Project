namespace KutuphaneYonetimSistemi
{
    partial class FormKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            buttonKitapEkle = new Button();
            buttonKitapBilgiGuncelle = new Button();
            buttonSil = new Button();
            groupBox5 = new GroupBox();
            buttonTumKitaplariGoster = new Button();
            buttonAra = new Button();
            buttonTemizle = new Button();
            textBoxKitapTurKodu = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYazarSoyad = new TextBox();
            textBoxYazarAdi = new TextBox();
            textBoxKitapAdi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelID = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonKitapOduncVer = new Button();
            dateTimePickerOduncAlmaTarihi = new DateTimePicker();
            textBoxOduncAlan = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            buttonKitabiIadeEt = new Button();
            label11 = new Label();
            labelGecikmeBedeli = new Label();
            buttonGecikmeBedeliHesapla = new Button();
            label10 = new Label();
            groupBox4 = new GroupBox();
            dataGridViewKitaplar = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(textBoxKitapTurKodu);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxYazarSoyad);
            groupBox1.Controls.Add(textBoxYazarAdi);
            groupBox1.Controls.Add(textBoxKitapAdi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(7, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(804, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Kayit ve Guncelleme";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(buttonKitapEkle);
            groupBox6.Controls.Add(buttonKitapBilgiGuncelle);
            groupBox6.Controls.Add(buttonSil);
            groupBox6.Location = new Point(3, 238);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(471, 78);
            groupBox6.TabIndex = 18;
            groupBox6.TabStop = false;
            groupBox6.Text = "Kayit Duzenleme Islemleri";
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonKitapEkle.Location = new Point(180, 29);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(180, 36);
            buttonKitapEkle.TabIndex = 11;
            buttonKitapEkle.Text = "Yeni Kitap Ekle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // buttonKitapBilgiGuncelle
            // 
            buttonKitapBilgiGuncelle.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonKitapBilgiGuncelle.Location = new Point(11, 29);
            buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            buttonKitapBilgiGuncelle.Size = new Size(163, 36);
            buttonKitapBilgiGuncelle.TabIndex = 12;
            buttonKitapBilgiGuncelle.Text = "Kitap Bilgileri Guncelle";
            buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            buttonKitapBilgiGuncelle.Click += buttonKitapBilgiGuncelle_Click;
            // 
            // buttonSil
            // 
            buttonSil.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSil.Location = new Point(366, 29);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(90, 35);
            buttonSil.TabIndex = 16;
            buttonSil.Text = "Kitap Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(buttonTumKitaplariGoster);
            groupBox5.Controls.Add(buttonAra);
            groupBox5.Controls.Add(buttonTemizle);
            groupBox5.Location = new Point(480, 211);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(324, 104);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Arama";
            // 
            // buttonTumKitaplariGoster
            // 
            buttonTumKitaplariGoster.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTumKitaplariGoster.Location = new Point(216, 43);
            buttonTumKitaplariGoster.Name = "buttonTumKitaplariGoster";
            buttonTumKitaplariGoster.Size = new Size(101, 57);
            buttonTumKitaplariGoster.TabIndex = 15;
            buttonTumKitaplariGoster.Text = "Tum Kitaplari Goster";
            buttonTumKitaplariGoster.UseVisualStyleBackColor = true;
            buttonTumKitaplariGoster.Click += buttonTumKitaplariGoster_Click;
            // 
            // buttonAra
            // 
            buttonAra.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAra.Location = new Point(120, 43);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(90, 57);
            buttonAra.TabIndex = 14;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // buttonTemizle
            // 
            buttonTemizle.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTemizle.Location = new Point(24, 43);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(90, 57);
            buttonTemizle.TabIndex = 13;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // textBoxKitapTurKodu
            // 
            textBoxKitapTurKodu.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKitapTurKodu.Location = new Point(143, 205);
            textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            textBoxKitapTurKodu.Size = new Size(167, 30);
            textBoxKitapTurKodu.TabIndex = 10;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxISBN.Location = new Point(143, 169);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(167, 30);
            textBoxISBN.TabIndex = 9;
            // 
            // textBoxYazarSoyad
            // 
            textBoxYazarSoyad.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYazarSoyad.Location = new Point(143, 133);
            textBoxYazarSoyad.Name = "textBoxYazarSoyad";
            textBoxYazarSoyad.Size = new Size(404, 30);
            textBoxYazarSoyad.TabIndex = 8;
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYazarAdi.Location = new Point(143, 96);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(404, 30);
            textBoxYazarAdi.TabIndex = 7;
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKitapAdi.Location = new Point(143, 59);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(404, 30);
            textBoxKitapAdi.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(0, 215);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 6;
            label7.Text = "Kitap Tur Kodu : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 175);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 5;
            label6.Text = "ISBN : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 139);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 4;
            label5.Text = "Yazar Soyad : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(-3, 102);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "Yazar Adi : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 65);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Kitap Adi : ";
            label3.Click += label3_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(143, 31);
            labelID.Name = "labelID";
            labelID.Size = new Size(11, 16);
            labelID.TabIndex = 1;
            labelID.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 34);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID : ";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonKitapOduncVer);
            groupBox2.Controls.Add(dateTimePickerOduncAlmaTarihi);
            groupBox2.Controls.Add(textBoxOduncAlan);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(817, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 304);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Odunc Alma";
            // 
            // buttonKitapOduncVer
            // 
            buttonKitapOduncVer.Font = new Font("Century", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonKitapOduncVer.Location = new Point(121, 140);
            buttonKitapOduncVer.Name = "buttonKitapOduncVer";
            buttonKitapOduncVer.Size = new Size(116, 47);
            buttonKitapOduncVer.TabIndex = 16;
            buttonKitapOduncVer.Text = "Kitabi Odunc Ver";
            buttonKitapOduncVer.UseVisualStyleBackColor = true;
            buttonKitapOduncVer.Click += buttonKitapOduncVer_Click;
            // 
            // dateTimePickerOduncAlmaTarihi
            // 
            dateTimePickerOduncAlmaTarihi.Location = new Point(121, 79);
            dateTimePickerOduncAlmaTarihi.Name = "dateTimePickerOduncAlmaTarihi";
            dateTimePickerOduncAlmaTarihi.Size = new Size(148, 27);
            dateTimePickerOduncAlmaTarihi.TabIndex = 6;
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOduncAlan.Location = new Point(121, 37);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(167, 30);
            textBoxOduncAlan.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 84);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 4;
            label9.Text = "Tarih : ";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 47);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 3;
            label8.Text = "Odunc Alan : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonKitabiIadeEt);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(labelGecikmeBedeli);
            groupBox3.Controls.Add(buttonGecikmeBedeliHesapla);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(1123, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(237, 304);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap Iade";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // buttonKitabiIadeEt
            // 
            buttonKitabiIadeEt.Font = new Font("Century", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonKitabiIadeEt.Location = new Point(65, 140);
            buttonKitabiIadeEt.Name = "buttonKitabiIadeEt";
            buttonKitabiIadeEt.Size = new Size(116, 47);
            buttonKitabiIadeEt.TabIndex = 15;
            buttonKitabiIadeEt.Text = "Kitabi Iade Et";
            buttonKitabiIadeEt.UseVisualStyleBackColor = true;
            buttonKitabiIadeEt.Click += buttonKitabiIadeEt_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(200, 43);
            label11.Name = "label11";
            label11.Size = new Size(31, 20);
            label11.TabIndex = 14;
            label11.Text = "TL";
            label11.Click += label11_Click;
            // 
            // labelGecikmeBedeli
            // 
            labelGecikmeBedeli.AutoSize = true;
            labelGecikmeBedeli.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelGecikmeBedeli.Location = new Point(143, 43);
            labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            labelGecikmeBedeli.Size = new Size(18, 20);
            labelGecikmeBedeli.TabIndex = 13;
            labelGecikmeBedeli.Text = "0";
            // 
            // buttonGecikmeBedeliHesapla
            // 
            buttonGecikmeBedeliHesapla.Font = new Font("Century", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGecikmeBedeliHesapla.Location = new Point(65, 87);
            buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            buttonGecikmeBedeliHesapla.Size = new Size(116, 47);
            buttonGecikmeBedeliHesapla.TabIndex = 12;
            buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = true;
            buttonGecikmeBedeliHesapla.Click += buttonGecikmeBedeliHesapla_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(6, 43);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 4;
            label10.Text = "Gecikme Bedeli : ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewKitaplar);
            groupBox4.Location = new Point(10, 323);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1350, 269);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(3, 19);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowTemplate.Height = 25;
            dataGridViewKitaplar.Size = new Size(1344, 247);
            dataGridViewKitaplar.TabIndex = 0;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
            dataGridViewKitaplar.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 604);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormKitaplar";
            Text = "Kutuphane Yonetim Sistemi";
            FormClosed += FormKitaplar_FormClosed;
            Load += FormKitaplar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label labelID;
        private Label label1;
        private GroupBox groupBox3;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyad;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private Button buttonKitapBilgiGuncelle;
        private Button buttonKitapEkle;
        private Label label9;
        private Label label8;
        private DateTimePicker dateTimePickerOduncAlmaTarihi;
        private TextBox textBoxOduncAlan;
        private Label label10;
        private Label label11;
        private Label labelGecikmeBedeli;
        private Button buttonGecikmeBedeliHesapla;
        private Button buttonKitapOduncVer;
        private Button buttonKitabiIadeEt;
        private Button buttonTemizle;
        private Button buttonAra;
        private Button buttonTumKitaplariGoster;
        private GroupBox groupBox5;
        private Button buttonSil;
        private GroupBox groupBox6;
    }
}