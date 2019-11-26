using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Maths_Quiz
{
    public class Player //creating the player class which includes their username and score
    {
        public static string Username;
        public static int Score;
        public static int HighScore;

        public Player(string name)
        {
            Username = name;
            Score = 0;
        }
        public static void ResetPlayer()
        {
            Username = "";
            Score = 0;
        }

        public static void IncreaseScore()
        {
            Score++;
        }

        public static void CheckScore()
        {
            if (Player.Score > Player.HighScore)
            {
                Player.HighScore = Player.Score;
            }            
        }

        public static void SaveScore()
        {
            string file = @"scores.txt";
            FileStream stream;
            StreamWriter sw;

            bool containsUser = false;

            CheckScore();

            try
            {
                if (!File.Exists(file))
                {
                    //Create scores file if it doesn't already exist
                    stream = new FileStream(file, FileMode.Create, FileAccess.Write);
                }
                else
                {
                    //Read data from scores file
                    string[] scores = File.ReadLines(file).ToArray();

                    stream = new FileStream(file, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(stream);

                    string[] scoresDetails = scores[1].Split('~');

                        string username = scoresDetails[0];
                        string score = scoresDetails[1];
                        string highscore = scoresDetails[2];

                    for (int i = 0; i < scores.Length; i++)
                    {
                        
                        //If player found update data in file
                        if (Username == scoresDetails[0])
                        {
                            sw.WriteLine(Username + "~" + Score + "~" + HighScore);
                            containsUser = true;
                        }

                        //If another player is found write back previous data in file
                        else
                        {
                            sw.WriteLine(username + "~" + score + "~" + highscore);
                        }
                    }
                    sw.Close();
                    stream.Close();

                    //Write player score data to file if it is not already there
                    if (containsUser == false)
                    {
                        stream = new FileStream(file, FileMode.Append, FileAccess.Write);
                        sw = new StreamWriter(stream);

                        sw.WriteLine(Username + "~" + Score + "~" + HighScore);

                        sw.Close();
                    }

                    //Write player score data to file if file is empty
                    if (scores.Length == 0)
                    {
                        stream = new FileStream(file, FileMode.Create, FileAccess.Write);
                        sw = new StreamWriter(stream);

                        sw.WriteLine(Username + "~" + Score + "~" + HighScore);

                        sw.Close();
                        stream.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error saving score", "Error");
            }
        }
    }
}
