using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplantı_Planlama
{
    public partial class UserControlGunler : UserControl
    {
        List<string> acceptedPeople = null;
        string date = "";
        public UserControlGunler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }
        
        private void UserControlGunler_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday, string date = "", List<string> acceptedPeople = null)
        {
            label1.Text = numday + "";

            this.date = date;

            if (date.Length > 0)
            {
                linkLabel1.Text = date;
                this.BackColor = Color.GreenYellow;
                this.acceptedPeople = acceptedPeople;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form kabulEtForm = new Form4(acceptedPeople, date);
            kabulEtForm.Show();
        }
    }
}
