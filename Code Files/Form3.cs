using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplantı_Planlama
{
    public partial class Form3 : Form
    {

        private string dosyaYolu = "ToplantıBilgi.txt";
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime toplantiTarihi = DateTime.Now;
            string filePath = textBox1.Text + ".json";
            Program.acilanToplantiKodu = filePath;
            Dictionary<string, List<string>> toplantiTarihleri = null;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string meetingInfo = reader.ReadToEnd();

                
                MeetingInfoModel meetingInfoModel = JsonConvert.DeserializeObject<MeetingInfoModel>(meetingInfo);

                
                string toplantiKisi = meetingInfoModel.OlusturanKisi;
                string toplantiBasligi = meetingInfoModel.Baslik;
                toplantiTarihleri = meetingInfoModel.OlasiTarihler;
                string toplantiaciklama = meetingInfoModel.Aciklama;
                string toplantikodu = meetingInfoModel.ToplantiKodu;

            }
            Form f1 = new Form1(toplantiTarihleri);
            f1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }

    public class MeetingInfoModel
    {
        public string OlusturanKisi { get; set; }
        public string Baslik { get; set; }
        public Dictionary<string, List<string>> OlasiTarihler { get; set; }
        public string Aciklama { get; set; }
        public string ToplantiKodu { get; set; }
    }
}
