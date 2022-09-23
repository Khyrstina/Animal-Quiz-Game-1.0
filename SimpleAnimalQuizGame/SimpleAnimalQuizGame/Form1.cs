using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAnimalQuizGame
{
    public partial class Form1 : Form
    {

        // quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;



        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 11;

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;

            }

            if(questionNumber == totalQuestions)
            {

                //this is the formula for percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percantage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"

                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {


            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.quiz_game_title;

                    lblQuestion.Text = "Every dog has its day... when is that?";

                    button1.Text = "Sunday";
                    button2.Text = "Tuesday";
                    button3.Text = "Every day";
                    button4.Text = "Never";


                    correctAnswer = 3;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.quiz_game_1_;

                    lblQuestion.Text = "Choose one of the following answers:";

                    button1.Text = "Get another cat";
                    button2.Text = "Mummify their deceased cat";
                    button3.Text = "Shave their eyebrows";
                    button4.Text = "Taxidermy their cat";


                    correctAnswer = 3;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.quiz_game_2_;

                    lblQuestion.Text = "Choose one of the following answers:";

                    button1.Text = "Pitbull";
                    button2.Text = "Beagle";
                    button3.Text = "Basset Hound";
                    button4.Text = "Mixed-Breed";


                    correctAnswer = 2;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.quiz_game_3_;

                    lblQuestion.Text = "Choose one of the following answers:";

                    button1.Text = "Ducks";
                    button2.Text = "Cows";
                    button3.Text = "Sheep";
                    button4.Text = "Reindeer";


                    correctAnswer = 4;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.quiz_game_4_;

                    lblQuestion.Text = "Choose one of the following answers:";

                    button1.Text = "Labradors";
                    button2.Text = "Chesapeake Bay Retriever";
                    button3.Text = "Newfoundlands";
                    button4.Text = "Portuguese Water Dog";


                    correctAnswer = 3;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.quiz_game_5_;

                    lblQuestion.Text = "Choose one of the following answers:";

                    button1.Text = "Persian";
                    button2.Text = "Siamese";
                    button3.Text = "Main Coon";
                    button4.Text = "Ragamuffin";


                    correctAnswer = 1;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.quiz_game_6_;

                    lblQuestion.Text = "Choose one of the following answers:";

                    button1.Text = "Grey and White";
                    button2.Text = "Purple and Orange";
                    button3.Text = "Red and Green";
                    button4.Text = "Blue and Yellow";


                    correctAnswer = 4;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.quiz_game_7_;

                    lblQuestion.Text = "Choose one of the following answers:";

                    button1.Text = "Blue";
                    button2.Text = "Red";
                    button3.Text = "Yellow";
                    button4.Text = "Green";


                    correctAnswer = 1;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.quiz_game_8_;

                    lblQuestion.Text = "Choose one of the following answers:";

                    button1.Text = "Cauldron";
                    button2.Text = "Grumble";
                    button3.Text = "Army";
                    button4.Text = "Congregation";


                    correctAnswer = 2;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.quiz_game_9_;

                    lblQuestion.Text = "Choose one of the following answers:";

                    button1.Text = "Conspiracy";
                    button2.Text = "Business";
                    button3.Text = "Obstinacy";
                    button4.Text = "Clowder";


                    correctAnswer = 4;

                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.quiz_game;

                    lblQuestion.Text = "Choose one of the following answers:";

                    button1.Text = "2";
                    button2.Text = "3";
                    button3.Text = "4";
                    button4.Text = "1.5";


                    correctAnswer = 2;

                    break;

            }

        }

    }
}
