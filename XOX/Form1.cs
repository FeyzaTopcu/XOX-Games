using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tiklanmaSayisi = 0;
        bool isaret = true;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (isaret == true)
            {
                btn.Text = "X";
                btn.BackColor = Color.Red;
            }
            else
            {
                btn.Text = "O";
                btn.BackColor = Color.Yellow;
            }

            btn.Enabled = false;
            isaret = !isaret;
            tiklanmaSayisi++;
            Kazanan();


        }
        void OyunuTekrarBaslat()
        {
            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    Button btn = item as Button;
                    btn.Enabled = true;
                    btn.Text = "";
                    btn.BackColor = Color.Empty;
                }
                
            }

            isaret = true;
            tiklanmaSayisi = 0;
            


        }
        void Kazanan()
        {
            bool kazananOyuncu = false;
            //yatay
            if ((btn00.Text == btn01.Text) && (btn01.Text == btn02.Text) && btn00.Text != "")
                kazananOyuncu =true;
            if ((btn10.Text == btn11.Text) && (btn11.Text == btn12.Text) && btn10.Text != "")
                kazananOyuncu= true;
            if ((btn20.Text == btn21.Text) && (btn21.Text == btn22.Text) && btn20.Text != "")
                kazananOyuncu =true;
            //dikey
            else if ((btn00.Text == btn10.Text) && (btn10.Text == btn20.Text) && btn00.Text != "")
                kazananOyuncu= true;
            if ((btn01.Text == btn11.Text) && (btn11.Text == btn21.Text) && btn01.Text != "")
                kazananOyuncu= true;
            if ((btn02.Text == btn12.Text) && (btn12.Text == btn22.Text) && btn02.Text != "")
                kazananOyuncu =true;
            //capraz
            else if ((btn00.Text == btn11.Text) && (btn11.Text == btn22.Text) && btn00.Text != "")
                kazananOyuncu =true;
            if ((btn02.Text == btn11.Text) && (btn11.Text == btn20.Text) && btn02.Text != "")
                kazananOyuncu =true;
            if (kazananOyuncu)
            {
                
                string kimkazandi = "";
                if (isaret)
                
                    kimkazandi = "O";
                    
                
                else
                    kimkazandi = "X";
                
                DialogResult dr = MessageBox.Show(kimkazandi + " Kazandı!\nTekrardan oynamak istiyor musunuz?", "Oyun Bitti", MessageBoxButtons.YesNo);
                
                

                if (dr == DialogResult.Yes)
                {
                    OyunuTekrarBaslat();
                }
                else
                {
                    Application.Exit();
                }

            }
            else
            {
                if (tiklanmaSayisi == 9)
                {
                    
                    DialogResult dr = MessageBox.Show("Berabere!\nTekrardan oynamak istiyor musunuz?", "Oyun Bitti", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        OyunuTekrarBaslat();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
               
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
        }
    }
}
