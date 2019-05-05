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
    public partial class Form2 : Form
    {
        Player currentPlayer;
        List<Button> buttons;
        Random rnd = new Random();
        int playerWins = 0;
        int computerWins = 0;

        public enum Player
        {
            X, O
        }


        public Form2()
        {
            InitializeComponent();
            resetGame();
        }

        private void playerClick(object sender, EventArgs e)
        {

            var button = (Button)sender;
            currentPlayer = Player.X;
            //progressBar1.ForeColor = Color.Red;
            button.Text = currentPlayer.ToString();
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.Red;

            buttons.Remove(button);
            Check();
            Almoves.Start();
        }

        private void Almove(object sender, EventArgs e)
        {

            if (buttons.Count > 0)
            {
                int index = rnd.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                //progressBar1.ForeColor= Color.DarkBlue;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = System.Drawing.Color.DarkBlue;
                buttons.RemoveAt(index);
                Check();
                Almoves.Stop();
            }
        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void resetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true;
                    ((Button)X).Text = "";
                    ((Button)X).BackColor = default(Color);
                }
            }
            loadbuttons();
            Check();
        }

        private void Check()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
               button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
               button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
               button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
               button3.Text == "X" && button5.Text == "X" && button7.Text == "X" ||
               button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
               button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
               button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                Almoves.Stop();
                MessageBox.Show("player wins");
                //playerWins++;
                resetGame();

            }
            else
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
               button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
               button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
               button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
               button3.Text == "O" && button5.Text == "O" && button7.Text == "O" ||
               button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
               button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
               button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                Almoves.Stop();
                MessageBox.Show("computer wins");
                computerWins++;
                resetGame();
            }

        }
        private void loadbuttons()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   
}
