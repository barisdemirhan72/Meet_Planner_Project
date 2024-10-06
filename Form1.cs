using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Toplantı_Planlama
{
    public partial class Form1 : Form
    {

        DateTime defaultDate = DateTime.Parse("1.1.1970");

        Dictionary<string, List<string>> toplantiTarihleri = null;

        DateTime now = DateTime.Now;

        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Dictionary<string, List<string>> toplantiTarihleri)
        {
            InitializeComponent();
            this.toplantiTarihleri = toplantiTarihleri;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays(toplantiTarihleri);
        }
        
        private void displayDays(Dictionary<string, List<string>> toplantiTarihleri)
        {
            
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            label1.Text = monthname + "  " + year;

            int days = DateTime.DaysInMonth(year, month);

            DateTime startofthemonth = new DateTime(year, month, 1);

            DateTime endofthemonth = new DateTime(year, month, days);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) ;

            if (dayoftheweek == 0) { dayoftheweek = 7; }

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 uc = new UserControl1();
                panel1.Controls.Add(uc);
            }

            for (int i = 1;i <= days; i++) 
            {
                UserControlGunler ucgunler = new UserControlGunler();

                
                if (toplantiTarihleri != null)
                {
                    var matchingDates = toplantiTarihleri
                    .Where(kv => DateTime.ParseExact(kv.Key, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture).Day == i
                    && DateTime.ParseExact(kv.Key, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture).Month == month
                    && DateTime.ParseExact(kv.Key, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture).Year == year)
                    .ToList();

                    if (matchingDates.Any())
                    {
                        
                        var firstMatchingDate = matchingDates.First();
                        List<string> acceptedPeople = firstMatchingDate.Value;

                        string dateString = firstMatchingDate.Key;

                        ucgunler.days(i, dateString, acceptedPeople);
                    }
                    else
                    {
                        ucgunler.days(i);
                    }
                }
                else
                {
                    ucgunler.days(i);
                }
                

                panel1.Controls.Add(ucgunler);
            }

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void toplantiplanlama_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            month--;

            if (month == 0)
            {
                year--;
                month = 12;
            }

            displayDays(toplantiTarihleri);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Sonraki_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            month++;

            if (month == 13)
            {
                year++;
                month = 1;
            }

            displayDays(toplantiTarihleri);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pazartesi_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 geri = new Form5();
            geri.Show();
            this.Hide();
        }
    }
}
