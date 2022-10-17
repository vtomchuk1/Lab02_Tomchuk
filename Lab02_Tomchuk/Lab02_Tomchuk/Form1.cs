using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Tomchuk
{
    public partial class Lab02_Tomchuk : Form
    {
        public Lab02_Tomchuk()
        {
            InitializeComponent();
        }

        private void Sbutton_Xor_Click(object sender, EventArgs e)
        {
            // encrypt
            string strP = Stextbox_P.Text;
            int intP = Convert.ToInt32(strP, 16);
            converter(intP, 'P');
            
            string strK = Stextbox_K.Text;
            int intK = Convert.ToInt32(strK, 16);
            converter(intK, 'K');

            int intC = intP ^ intK;
            converter(intC, 'C');
            string strC = Convert.ToString(intC, 16);
            Stextbox_C.Text = strC;

            //decrypt

            Dtextbox_C.Text = strC;
            Dtextbox_K.Text = strK;
            int DintP = intK ^ intC;
            string DstrP = Convert.ToString(DintP, 16);
            Dtextbox_P.Text = DstrP;
        }

        private void converter(int num, char locate)
        {
            string hex = Convert.ToString(num, 2);
            string dec = Convert.ToString(num, 10);
            string bin = Convert.ToString(num, 16);
            switch (locate)
            {
                case 'P':
                    {
                        Slabel_P_2.Text = bin;
                        Slabel_P_10.Text = dec;
                        Slabel_P_16.Text = hex;
                        break;
                    }
                case 'K':
                    {
                        Slabel_K_2.Text = bin;
                        Slabel_K_10.Text = dec;
                        Slabel_K_16.Text = hex;
                        break;
                    }
                case 'C':
                    {
                        Slabel_C_2.Text = bin;
                        Slabel_C_10.Text = dec;
                        Slabel_C_16.Text = hex;
                        break;
                    }
            }
        }

        private void Sbutton_Clear_Click(object sender, EventArgs e)
        {
            Stextbox_C.Text = "";
            Stextbox_K.Text = "";
            Stextbox_P.Text = "";
            Slabel_P_2.Text = "";
            Slabel_P_10.Text = "";
            Slabel_P_16.Text = "";
            Slabel_K_2.Text = "";
            Slabel_K_10.Text = "";
            Slabel_K_16.Text = "";
            Slabel_C_2.Text = "";
            Slabel_C_10.Text = "";
            Slabel_C_16.Text = "";
            Dtextbox_C.Text = "";
            Dtextbox_K.Text = "";
            Dtextbox_P.Text = "";
        }
    }
}
