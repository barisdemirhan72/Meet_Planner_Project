using Newtonsoft.Json;
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

namespace Toplantı_Planlama
{
    public partial class Form4 : Form
    {
        string date = "";
        List<string> acceptedPeople;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(List<string> acceptedPeople, string date)
        {
            InitializeComponent();
            this.acceptedPeople = acceptedPeople;
            this.date = date;
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (var item in acceptedPeople)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPersonToToplantiTarihleri(Program.acilanToplantiKodu, date, Program.girisYapanKisi);
            this.Close();
        }

        private void AddPersonToToplantiTarihleri(string filePath, string dateString, string newPerson)
        {
            
            string jsonContent = File.ReadAllText(filePath);

            
            MeetingInfoModel meetingInfoModel = JsonConvert.DeserializeObject<MeetingInfoModel>(jsonContent);

            
            if (meetingInfoModel.OlasiTarihler.ContainsKey(dateString))
            {
               
                meetingInfoModel.OlasiTarihler[dateString].Add(newPerson);
            }
            else
            {
                
                meetingInfoModel.OlasiTarihler[dateString] = new List<string> { newPerson };
            }

            
            string updatedJson = JsonConvert.SerializeObject(meetingInfoModel, Formatting.Indented);

            
            File.WriteAllText(filePath, updatedJson);
        }
    }
}
