using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRC1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnKliko_Click(object sender, EventArgs e)
        {
            String vlera = konverto(txtTeksti.Text);
            String vlera1 = konverto(txtTeksti.Text) + "0000000000000000";
            String vlera2 = "";
            String vlera3 = "";
            String vlera4 = "";
            String vlera5 = "";
            String vlera6 = "";
            char[] char1 = vlera1.ToCharArray();
            char[] char2 = { };
            char[] char3 = { };
            char[] char4 = { };
            char[] divisor = { '1', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '1' };


            
          
            int y = 0;
            int n = vlera1.Length;
            for (int j = 0; j <vlera1.Length-18; j++)
            {
                if (j == 0)
                {
                     char2 = char1;
                }
                else
                {
                    char2 = vlera6.ToCharArray();
                }
                
               
                for (int i = 0; i <char2.Length; i++)
                {
                    if (char2[i] == '1')
                    {
                        if (j == 0)
                        {
                            vlera2 = vlera1.Substring(i, n - 1);
                            y=y + i;
                            break;
                        }
                        else
                        {
                            vlera2 = vlera6.Substring(i,vlera6.Length-i);
                            y = y + i;
                            break;
                        }
                        
                    }
                    else
                    {
                        
                        continue;
                    }
                   
                }

                if (vlera2.Length < 17)
                {
                    break;
                }
                
                    vlera3 = vlera2.Substring(0, 17);
                     char3 = vlera3.ToCharArray();
                    

                    int m = vlera2.Length;
                    for (int i = 0; i < char3.Length; i++)
                    {
                        if (char3[i] == divisor[i])
                        {
                            char3[i] = '0';
                        }
                        else
                        {
                            char3[i] = '1';
                        }
                    }

              char4 = (vlera1.Substring(17+y , vlera1.Length - 17-y)).ToCharArray();

                vlera4 = new String(char3);
                vlera5 = new String(char4);
              
               vlera6 = vlera4 + vlera5;
                
                    
            }
           

            String vlera7= vlera + vlera6.Substring(vlera6.Length -16, 16);
            txtCRC.Text = vlera6.Substring(vlera6.Length - 16, 16);
            txtRezultati.Text =vlera7;

        }
        public string konverto(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char A in str.ToCharArray())
            {
                sb.Append(Convert.ToString(A, 2).PadLeft(8, '0'));

            }
            return sb.ToString();
        }








        private void btnVertetimi_Click(object sender, EventArgs e)
        {
           
            String vlera1 = txtRezultati.Text;
            String vlera2 = "";
            String vlera3 = "";
            String vlera4 = "";
            String vlera5 = "";
            String vlera6 = "";
            char[] char1 = vlera1.ToCharArray();
            char[] char2 = { };
            char[] char3 = { };
            char[] char4 = { };
            char[] divisor = { '1', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '1' };

            int y = 0;
            int n = vlera1.Length;
            
            
            for (int j = 0; j <vlera1.Length-18; j++)
            {
                if (j == 0)
                {
                    char2 = char1;
                }
                else
                {
                    char2 = vlera6.ToCharArray();
                }


                for (int i = 0; i < char2.Length; i++)
                {
                    
                    if (char2[i] == '1')
                    {

                        if (j == 0)
                        {
                            vlera2 = vlera1.Substring(i, n - 1);
                            y = y + i;
                            break;
                        }
                       
                        else
                        {
                            vlera2 = vlera6.Substring(i, vlera6.Length - i);
                            y = y + i;
                            break;
                        }
                    }
                    
                    else 
                    {
                        continue;
                    }


                }
                
                if (vlera2.Length < 17)
                {
                    break;
                }



                vlera3 = vlera2.Substring(0, 17);
                char3 = vlera3.ToCharArray();
                int m = vlera2.Length;


                for (int i = 0; i < char3.Length; i++)
                {
                    if (char3[i] == divisor[i])
                    {
                        char3[i] = '0';
                    }
                    else
                    {
                        char3[i] = '1';
                    }
                }

                 char4 = (vlera1.Substring(17+y, vlera1.Length-17-y)).ToCharArray();

                vlera4 = new String(char3);
                vlera5 = new String(char4);
                vlera6 = vlera4+vlera5;
            }

            txtVertetimi.Text = vlera6;
            char[] char5 = new char[vlera6.Length];
            for(int k=0;k<vlera6.Length;k++)
            {
                char5[k] ='0';
            }

            String vlera7 = new String(char5);
            
            if(vlera7.Equals(vlera6))
            {
                txtMesazhi.Text = "Nuk është ndryshuar";
            }
            else
            {
                txtMesazhi.Text = "Eshte ndryshuar";
            }
            

        }
    }
}
