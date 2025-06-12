namespace RBackup
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            postgreYedekle = new Button();
            groupBox1 = new GroupBox();
            yedeklemeSure = new NumericUpDown();
            yedeklemeText = new Label();
            postgreKullanici = new TextBox();
            label10 = new Label();
            label9 = new Label();
            pg_dump_sec = new Button();
            postgreVeritabani = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            otomatikYedekleCheckbox = new CheckBox();
            ayarlariKaydet = new Button();
            postgrePort = new TextBox();
            label5 = new Label();
            postgreSifre = new TextBox();
            label4 = new Label();
            postgreSunucu = new TextBox();
            label3 = new Label();
            pg_dumpKlasoru = new TextBox();
            label2 = new Label();
            windowsBasla = new Button();
            yedekKlasorunuAc = new Button();
            label1 = new Label();
            bilgiMesajlari = new ListBox();
            otomatikYedekleTimer = new System.Windows.Forms.Timer(components);
            loglariTemizle = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yedeklemeSure).BeginInit();
            SuspendLayout();
            // 
            // postgreYedekle
            // 
            postgreYedekle.Location = new Point(633, 327);
            postgreYedekle.Name = "postgreYedekle";
            postgreYedekle.Size = new Size(227, 33);
            postgreYedekle.TabIndex = 0;
            postgreYedekle.Text = "Manuel Yedek Al";
            postgreYedekle.UseVisualStyleBackColor = true;
            postgreYedekle.Click += postgreYedekle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(yedeklemeSure);
            groupBox1.Controls.Add(yedeklemeText);
            groupBox1.Controls.Add(postgreKullanici);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(pg_dump_sec);
            groupBox1.Controls.Add(postgreVeritabani);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(otomatikYedekleCheckbox);
            groupBox1.Controls.Add(ayarlariKaydet);
            groupBox1.Controls.Add(postgrePort);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(postgreSifre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(postgreSunucu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pg_dumpKlasoru);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 342);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ayarlar";
            // 
            // yedeklemeSure
            // 
            yedeklemeSure.Location = new Point(10, 229);
            yedeklemeSure.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            yedeklemeSure.Name = "yedeklemeSure";
            yedeklemeSure.Size = new Size(55, 25);
            yedeklemeSure.TabIndex = 22;
            yedeklemeSure.Value = new decimal(new int[] { 180, 0, 0, 0 });
            // 
            // yedeklemeText
            // 
            yedeklemeText.AutoSize = true;
            yedeklemeText.Location = new Point(66, 307);
            yedeklemeText.Name = "yedeklemeText";
            yedeklemeText.Size = new Size(17, 17);
            yedeklemeText.TabIndex = 5;
            yedeklemeText.Text = "...";
            // 
            // postgreKullanici
            // 
            postgreKullanici.BorderStyle = BorderStyle.FixedSingle;
            postgreKullanici.Location = new Point(323, 167);
            postgreKullanici.Name = "postgreKullanici";
            postgreKullanici.Size = new Size(115, 25);
            postgreKullanici.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 307);
            label10.Name = "label10";
            label10.Size = new Size(50, 17);
            label10.TabIndex = 4;
            label10.Text = "Durum:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(319, 146);
            label9.Name = "label9";
            label9.Size = new Size(104, 17);
            label9.TabIndex = 20;
            label9.Text = "Postgre Kullanıcı";
            // 
            // pg_dump_sec
            // 
            pg_dump_sec.Location = new Point(363, 42);
            pg_dump_sec.Name = "pg_dump_sec";
            pg_dump_sec.Size = new Size(75, 25);
            pg_dump_sec.TabIndex = 19;
            pg_dump_sec.Text = "Gözat";
            pg_dump_sec.UseVisualStyleBackColor = true;
            pg_dump_sec.Click += pg_dump_sec_Click;
            // 
            // postgreVeritabani
            // 
            postgreVeritabani.BorderStyle = BorderStyle.FixedSingle;
            postgreVeritabani.Location = new Point(10, 101);
            postgreVeritabani.Name = "postgreVeritabani";
            postgreVeritabani.Size = new Size(428, 25);
            postgreVeritabani.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 81);
            label8.Name = "label8";
            label8.Size = new Size(115, 17);
            label8.TabIndex = 17;
            label8.Text = "Postgre Veritabanı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 208);
            label7.Name = "label7";
            label7.Size = new Size(107, 17);
            label7.TabIndex = 16;
            label7.Text = "Yedekleme Sıklığı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 231);
            label6.Name = "label6";
            label6.Size = new Size(154, 17);
            label6.TabIndex = 14;
            label6.Text = "dakikada bir yedeklensin.";
            // 
            // otomatikYedekleCheckbox
            // 
            otomatikYedekleCheckbox.AutoSize = true;
            otomatikYedekleCheckbox.Location = new Point(10, 260);
            otomatikYedekleCheckbox.Name = "otomatikYedekleCheckbox";
            otomatikYedekleCheckbox.Size = new Size(128, 21);
            otomatikYedekleCheckbox.TabIndex = 13;
            otomatikYedekleCheckbox.Text = "Otomatik Yedekle";
            otomatikYedekleCheckbox.UseVisualStyleBackColor = true;
            // 
            // ayarlariKaydet
            // 
            ayarlariKaydet.Location = new Point(262, 248);
            ayarlariKaydet.Name = "ayarlariKaydet";
            ayarlariKaydet.Size = new Size(176, 33);
            ayarlariKaydet.TabIndex = 12;
            ayarlariKaydet.Text = "Ayarları Kaydet";
            ayarlariKaydet.UseVisualStyleBackColor = true;
            ayarlariKaydet.Click += ayarlariKaydet_Click;
            // 
            // postgrePort
            // 
            postgrePort.BorderStyle = BorderStyle.FixedSingle;
            postgrePort.Location = new Point(238, 167);
            postgrePort.Name = "postgrePort";
            postgrePort.Size = new Size(79, 25);
            postgrePort.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 147);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 10;
            label5.Text = "Postgre Port";
            // 
            // postgreSifre
            // 
            postgreSifre.BorderStyle = BorderStyle.FixedSingle;
            postgreSifre.Location = new Point(133, 167);
            postgreSifre.Name = "postgreSifre";
            postgreSifre.PasswordChar = '*';
            postgreSifre.Size = new Size(99, 25);
            postgreSifre.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 147);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 8;
            label4.Text = "Postgre Şifre";
            label4.Click += label4_Click;
            // 
            // postgreSunucu
            // 
            postgreSunucu.BorderStyle = BorderStyle.FixedSingle;
            postgreSunucu.Location = new Point(10, 167);
            postgreSunucu.Name = "postgreSunucu";
            postgreSunucu.Size = new Size(117, 25);
            postgreSunucu.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 146);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 6;
            label3.Text = "Postgre Sunucu IP";
            // 
            // pg_dumpKlasoru
            // 
            pg_dumpKlasoru.BorderStyle = BorderStyle.FixedSingle;
            pg_dumpKlasoru.Location = new Point(10, 42);
            pg_dumpKlasoru.Name = "pg_dumpKlasoru";
            pg_dumpKlasoru.Size = new Size(347, 25);
            pg_dumpKlasoru.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(111, 17);
            label2.TabIndex = 4;
            label2.Text = "pg_dump Klasörü";
            // 
            // windowsBasla
            // 
            windowsBasla.Location = new Point(468, 327);
            windowsBasla.Name = "windowsBasla";
            windowsBasla.Size = new Size(159, 33);
            windowsBasla.TabIndex = 3;
            windowsBasla.Text = "Windows ile Başlat";
            windowsBasla.UseVisualStyleBackColor = true;
            windowsBasla.Click += windowsBasla_Click;
            // 
            // yedekKlasorunuAc
            // 
            yedekKlasorunuAc.Location = new Point(866, 327);
            yedekKlasorunuAc.Name = "yedekKlasorunuAc";
            yedekKlasorunuAc.Size = new Size(176, 33);
            yedekKlasorunuAc.TabIndex = 2;
            yedekKlasorunuAc.Text = "Yedekleri Göster";
            yedekKlasorunuAc.UseVisualStyleBackColor = true;
            yedekKlasorunuAc.Click += yedekKlasorunuAc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(468, 18);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 2;
            label1.Text = "Bilgi Mesajları:";
            // 
            // bilgiMesajlari
            // 
            bilgiMesajlari.FormattingEnabled = true;
            bilgiMesajlari.HorizontalScrollbar = true;
            bilgiMesajlari.ItemHeight = 17;
            bilgiMesajlari.Location = new Point(468, 45);
            bilgiMesajlari.Name = "bilgiMesajlari";
            bilgiMesajlari.ScrollAlwaysVisible = true;
            bilgiMesajlari.Size = new Size(574, 276);
            bilgiMesajlari.TabIndex = 3;
            // 
            // otomatikYedekleTimer
            // 
            otomatikYedekleTimer.Enabled = true;
            otomatikYedekleTimer.Interval = 1000;
            otomatikYedekleTimer.Tick += otomatikYedekleTimer_Tick;
            // 
            // loglariTemizle
            // 
            loglariTemizle.Location = new Point(967, 13);
            loglariTemizle.Name = "loglariTemizle";
            loglariTemizle.Size = new Size(75, 26);
            loglariTemizle.TabIndex = 23;
            loglariTemizle.Text = "Temizle";
            loglariTemizle.UseVisualStyleBackColor = true;
            loglariTemizle.Click += loglariTemizle_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 378);
            Controls.Add(loglariTemizle);
            Controls.Add(bilgiMesajlari);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(yedekKlasorunuAc);
            Controls.Add(postgreYedekle);
            Controls.Add(windowsBasla);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RBACKUP";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yedeklemeSure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button postgreYedekle;
        private GroupBox groupBox1;
        private Button yedekKlasorunuAc;
        private Label label1;
        private TextBox postgreSunucu;
        private TextBox pg_dumpKlasoru;
        private Label label2;
        private Button windowsBasla;
        private ListBox bilgiMesajlari;
        private CheckBox otomatikYedekleCheckbox;
        private Button ayarlariKaydet;
        private TextBox postgrePort;
        private Label label5;
        private TextBox postgreSifre;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label3;
        private System.Windows.Forms.Timer otomatikYedekleTimer;
        private TextBox postgreVeritabani;
        private Label label8;
        private Button pg_dump_sec;
        private TextBox postgreKullanici;
        private Label label9;
        private Label label10;
        private Label yedeklemeText;
        private NumericUpDown yedeklemeSure;
        private Button loglariTemizle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}