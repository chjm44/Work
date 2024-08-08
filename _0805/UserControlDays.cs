using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _0805
{
    public partial class UserControlDays : UserControl
    {

        public UserControlDays()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        
        private void UserControlDays_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("선택 되었습니다.", form1.monthname + "월" + lbdays.Text + "일");
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        
    }
}
