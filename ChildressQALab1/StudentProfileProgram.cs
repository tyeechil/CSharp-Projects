using System;
using System.Windows.Forms;
using System.Web;

namespace QALab2
{
    public partial class StudentProfileProgram : Form
    {
        public StudentProfileProgram()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            MakeForm();
        }

        private void number1txt_TextChanged(object sender, EventArgs e)
        {
            if (((number1txt.TextLength == 3)))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void number2txt_TextChanged(object sender, EventArgs e)
        {
            if (((number2txt.TextLength == 3)))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void number3txt_TextChanged(object sender, EventArgs e)
        {
            if (((number3txt.TextLength == 4)))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TUIDtxt_TextChanged(object sender, EventArgs e)
        {
            if (((TUIDtxt.TextLength == 9)))
            {
                SendKeys.Send("{TAB}");
            }
        }
        protected void MakeForm()
        {
            if (String.IsNullOrEmpty(FirstNametxt.Text) || String.IsNullOrEmpty(LastNametxt.Text)) {
                MessageBox.Show("Please insert your first and last names");
            }
            string fullname = FirstNametxt + " " + MiddleNametxt + " " + LastNametxt;

            string phonenumber = number1txt + "-" + number2txt + "-" + number3txt;

            string TUID = TUIDtxt.Text;
            bool TUIDVal = false;
            while (TUIDVal == false)
            {
                if (TUID.Length != 9)
                {
                    MessageBox.Show("TUID must be 9 digits");
                    break;
                }
                else if (!(TUID.Contains("91"))) {
                    MessageBox.Show("TUIDs start with 915 or 914");
                    break;
                }
                else { TUIDVal = true;
                }


            }


        }
    }
}

