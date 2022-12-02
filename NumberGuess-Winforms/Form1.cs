using System;

namespace NumberGuess_Winforms
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<Label> lblResults = new List<Label>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();

        int answer = 0;
        int numGuess = 0;
        int intRandomMax = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            ResetGame();

        }

        private void InitializeGame()
        {
            //Add labels
            lblResults.Add(label1);
            lblResults.Add(label2);
            lblResults.Add(label3);
            lblResults.Add(label4);
            lblResults.Add(label5);
            //Add pic boxes
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);
        }

        private void ResetGame()
        {
            foreach (Label label in lblResults)
            {
                label.Text = "";
            }

            foreach(PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Image = null;
            }
            txtGuess.Enabled = false;
            btnStart.Enabled = true;
            btnStart.Text = "Start";
            numGuess = 0;
            txtGuess.Text = "";
            txtMessageBox.Text = "";
        }

        private void StartGame()
        {
            answer = random.Next(1, intRandomMax + 1);
            txtGuess.Enabled = true;
            btnStart.Text = "Reset";
            txtMessageBox.Text = "Guess between 1 and " + intRandomMax;
        }

        private void GameWon()
        {
            txtGuess.Enabled = false;
            txtMessageBox.Text = "You won!!";
        }

        private void GameLost()
        {
            txtGuess.Enabled = false;
            txtMessageBox.Text = "You lost :(";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                StartGame();
            }
            else
            {
                ResetGame();
            }
        }

        private void easyBtn_CheckedChanged(object sender, EventArgs e)
        {
            //Set difficulty to easy
            RadioButton btnEasy = (RadioButton)sender;
            if (btnEasy.Checked)
            {
                intRandomMax = 5;
            }
        }

        private void medBtn_CheckedChanged(object sender, EventArgs e)
        {
            //Set difficulty to normal
            RadioButton btnNormal = (RadioButton)sender;
            if (btnNormal.Checked)
            {
                intRandomMax = 20;
            }
        }

        private void hardBtn_CheckedChanged(object sender, EventArgs e)
        {
            //Set difficulty to hard
            RadioButton btnHard = (RadioButton)sender;
            if (btnHard.Checked)
            {
                intRandomMax = 50;
            }
        }

        private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String text = txtGuess.Text;
                int intText = int.Parse(text);
                if (intText == answer)
                {
                    lblResults[numGuess].Text = text + " Correct!";
                    lblResults[numGuess].ForeColor = Color.Green;
                    pictureBoxes[numGuess].Image = Properties.Resources.correct_icon;
                    GameWon();
                }
                else
                {
                    if (intText > answer)
                    {
                        lblResults[numGuess].Text = "Too high!";
                    }
                    else
                    {
                        lblResults[numGuess].Text = "Too Low!";
                        
                    }
                    lblResults[numGuess].ForeColor = Color.Red;
                    pictureBoxes[numGuess].Image = Properties.Resources.incorrect_icon;
                    if (numGuess >= 4)
                    {
                        GameLost();
                    }
                }
                numGuess++;
            }
        }
    }
}