using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RBackup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void ayarlariKaydet_Click(object sender, EventArgs e)
        {
            RBackup.Default.otomatikYedekleCheckbox = otomatikYedekleCheckbox.Checked ? true : false;
            RBackup.Default.yedeklemeSuresi = yedeklemeSure.Value;
            RBackup.Default.postgrePort = postgrePort.Text;
            RBackup.Default.postgreSifre = postgreSifre.Text;
            RBackup.Default.postgreSunucu = postgreSunucu.Text;
            RBackup.Default.postgreVeritabani = postgreVeritabani.Text;
            RBackup.Default.pg_dumpKlasoru = pg_dumpKlasoru.Text;
            RBackup.Default.postgreKullanici = postgreKullanici.Text;
            RBackup.Default.Save();
            MessageBox.Show("Baþarýyla kaydedildi.", "Ayarlarýnýzý Kaydettik!");
        }

        private void pg_dump_sec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Program Files\PostgreSQL";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.AutoUpgradeEnabled = false;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != null)
            {
                pg_dumpKlasoru.Text = openFileDialog1.FileName.Replace("/", "\\");
            }
        }

        private void yedekKlasorunuAc_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "backups");
        }

        private void windowsBasla_Click(object sender, EventArgs e)
        {
            RegistryKey RBackupStartWindows = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            RBackupStartWindows.SetValue("RamazanBackup", Application.ExecutablePath);
            MessageBox.Show("Windows ile baþlatýlacak!", "Uygulama Kaydedildi.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            otomatikYedekleCheckbox.Checked = RBackup.Default.otomatikYedekleCheckbox;
            yedeklemeSure.Value = RBackup.Default.yedeklemeSuresi;
            postgrePort.Text = RBackup.Default.postgrePort;
            postgreSifre.Text = RBackup.Default.postgreSifre;
            postgreSunucu.Text = RBackup.Default.postgreSunucu;
            postgreVeritabani.Text = RBackup.Default.postgreVeritabani;
            pg_dumpKlasoru.Text = RBackup.Default.pg_dumpKlasoru;
            postgreKullanici.Text = RBackup.Default.postgreKullanici;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var msg = MessageBox.Show("Dikkat veritabaný artýk yedeklenmeyecek!", "Kapatýlsýn mý?", MessageBoxButtons.YesNo);

            if (msg == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void otomatikYedekleTimer_Tick(object sender, EventArgs e)
        {
            if (!otomatikYedekleCheckbox.Checked)
            {
                yedeklemeText.Text = "Otomatik Yedekleme Kapalý.";
                yedeklemeText.ForeColor = Color.Red;
                return;
            }

            if (!backgroundWorker1.IsBusy)
            {
                yedeklemeText.Text = "Otomatik Yedekleniyor...";
                yedeklemeText.ForeColor = Color.Green;
           
                try
                {
                    otomatikYedekleTimer.Interval = (Int32)yedeklemeSure.Value * 60000;
                    backgroundWorker1.RunWorkerAsync();
                }
                catch (Exception error)
                {
                    yedeklemeText.Text = error.Message;
                }
            }
        }




        private void postgreYedekle_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                yedeklemeText.Text = "Manuel Yedekleniyor...";
                yedeklemeText.ForeColor = Color.Green;
                try
                {
                    backgroundWorker1.RunWorkerAsync();
                } catch (Exception error) {
                    yedeklemeText.Text = error.Message;
                }
            } else
            {
                yedeklemeText.Text = "Arkaplanda bir iþlem devam ediyor. Bir süre sonra tekrar deneyin.";
            }
        }

        private void loglariTemizle_Click(object sender, EventArgs e)
        {
            bilgiMesajlari.Items.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string dateTime = DateTime.Now.ToString("dd-MM-yyyy_HH.mm.ss");
            string fileName = $"backups\\webyedek{dateTime}.sql";

            this.Invoke(new Action(() =>
            {
                yedeklemeText.Text = $"Yedekleniyor... Lütfen bekleyin... Dosya Adý: {fileName}";
            }));

            Process p = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    ArgumentList = {
                "/c",
                $"set PGPASSWORD={postgreSifre.Text}&pg_dump -h {postgreSunucu.Text} -U {postgreKullanici.Text} -p {postgrePort.Text} {postgreVeritabani.Text} > {fileName}",
            },
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    CreateNoWindow = true,
                }
            };

            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardError.ReadToEnd();
            p.WaitForExit();

            e.Result = new
            {
                Output = output,
                Error = error,
                BackupTime = dateTime
            };
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            dynamic result = e.Result;
            string output = result.Output;
            string error = result.Error;
            string dateTime = result.BackupTime;

            if (!string.IsNullOrEmpty(output) || !string.IsNullOrEmpty(error))
            {
                bilgiMesajlari.Items.Insert(0, output + "-" + error);
            }
            else
            {
                bilgiMesajlari.Items.Insert(0, $"Son yedek tarihi: {dateTime}");
            }

            yedeklemeText.Text = "Yedekleme tamamlandý.";
            yedeklemeText.ForeColor = Color.Blue;
        }
    }
}