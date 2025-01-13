using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Toplantı_Planlama
{
    public partial class Form2 : Form
    {
        private string dosyaYolu = "ToplantıBilgi.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom; dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            toplantikisi.Text = Program.girisYapanKisi;
            toplantikisi.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toplantiKisi = this.toplantikisi.Text;
            string toplantiBasligi = this.toplantibasligi.Text;
            Dictionary<string, List<string>> toplantiTarihleri = lstTarihListesi.Items
                .Cast<DateTime>()
                .ToDictionary(
                    date => date.ToString("dd.MM.yyyy HH:mm"), 
                    date => new List<string>()); 
            string toplantiaciklama = this.toplantiaciklama.Text;
            string toplantikodu = Guid.NewGuid().ToString("N");

            using (StreamWriter file = File.CreateText(toplantikodu + ".json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartObject();

                writer.WritePropertyName("olusturanKisi");
                writer.WriteValue(toplantiKisi);

                writer.WritePropertyName("baslik");
                writer.WriteValue(toplantiBasligi);

                writer.WritePropertyName("olasiTarihler");
                writer.WriteStartObject();
                foreach (var tarih in toplantiTarihleri)
                {
                    
                    writer.WritePropertyName(tarih.Key);
                    writer.WriteStartArray();
                    foreach (var acceptedPerson in tarih.Value)
                    {
                        writer.WriteValue(acceptedPerson);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();

                writer.WritePropertyName("aciklama");
                writer.WriteValue(toplantiaciklama);

                writer.WritePropertyName("toplantiKodu");
                writer.WriteValue(toplantikodu);

                writer.WriteEndObject();
            }

            Clipboard.SetText(toplantikodu);
            MessageBox.Show("Toplantı kodunuz panoya kopyalandı. Kod: " + toplantikodu , "Toplantı Oluşturuldu!" );
        }

        private void toplantikisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnTarihEkle_Click(object sender, EventArgs e)
        {
            lstTarihListesi.Items.Add(dateTimePicker1.Value);
        }

        private void btnTarihKaldir_Click(object sender, EventArgs e)
        {
            lstTarihListesi.Items.Remove(dateTimePicker1.Value);
        }
    }
}
