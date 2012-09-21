using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3T
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool player1;
        bool player2;

        string p1;
        string p2;

        uint[,] play1;
        uint[,] play2;
        uint count;

        public MainWindow()
        {
            Console.WriteLine("Component Initialization Start");
            InitializeComponent();
            Console.WriteLine("Component Initialization End");
            Clear();
        }
        
        void InitializeMark()
        {
            player1 = true;
            player2 = false;
            count = 0;

            play1 = new uint[,]{
                    {0,0,0},
                    {0,0,0},
                    {0,0,0}
                    };


            play2 = new uint[,]{
                    {0,0,0},
                    {0,0,0},
                    {0,0,0}
                    };

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        void Clear()
    {

        p1 = "X";
        p2 = "O";

            textBox10.FontSize = 18;
            textBox10.AppendText(p1);

            textBox11.FontSize = 18;
            textBox11.AppendText(p2);


            textBox1.FontSize = 68;
            textBox2.FontSize = 68;
            textBox3.FontSize = 68;
            textBox4.FontSize = 68;
            textBox5.FontSize = 68;
            textBox6.FontSize = 68;
            textBox7.FontSize = 68;
            textBox8.FontSize = 68;
            textBox9.FontSize = 68;

            Disable_all();
                                  
    }
        void Disable_all()
        {
            
        button2.IsEnabled = false;
            button3.IsEnabled = false;
            button4.IsEnabled = false;
            button5.IsEnabled = false;
            button6.IsEnabled = false;
            button7.IsEnabled = false;
            button8.IsEnabled = false;
            button9.IsEnabled = false;
            button10.IsEnabled = false;


        }
        void Play()
        {
            
            textBox2.AppendText(p2);
            textBox3.AppendText(p1);
            textBox4.AppendText(p2);
            textBox5.AppendText(p1);
            textBox6.AppendText(p2);
            textBox7.AppendText(p1);
            textBox8.AppendText(p2);
            textBox9.AppendText(p1);
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            InitializeMark();
            textBox12.FontSize = 18;
            textBox12.Clear();
            textBox12.AppendText("Player1's Turn");
            button1.IsEnabled = false;


            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
            button10.IsEnabled = true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            button2.IsEnabled = false;
            if (player1 == true)
            {
                textBox1.AppendText(p1);
                player1 = false;
                player2 = true;
                textBox12.Clear();
                textBox12.AppendText("Player2's Turn");
                play1[0,0] = 1;
                count++;
            }
            else
            {
                textBox1.AppendText(p2);
                player1 = true;
                player2 = false;
                textBox12.Clear();
                textBox12.AppendText("Player1's Turn");
                play2[0,0] = 1;
                count++;
            }
            check();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            button3.IsEnabled = false;
            if (player1 == true)
            {
                textBox2.AppendText(p1);
                player1 = false;
                player2 = true;
                textBox12.Clear();
                textBox12.AppendText("Player2's Turn");
                play1[0, 1] = 1;
                count++;
            }
            else
            {
                textBox2.AppendText(p2);
                player1 = true;
                player2 = false;
                textBox12.Clear();
                textBox12.AppendText("Player1's Turn");
                play2[0, 1] = 1;
                count++;
            }
            check();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            button4.IsEnabled = false;
            if (player1 == true)
            {
                textBox3.AppendText(p1);
                player1 = false;
                player2 = true;
                textBox12.Clear();
                textBox12.AppendText("Player2's Turn");
                play1[0, 2] = 1;
                count++;
            }
            else
            {
                textBox3.AppendText(p2);
                player1 = true;
                player2 = false;
                textBox12.Clear();
                textBox12.AppendText("Player1's Turn");
                play2[0, 2] = 1;
                count++;
            }
            check();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            button10.IsEnabled = false;
            if (player1 == true)
            {
                textBox4.AppendText(p1);
                player1 = false;
                player2 = true;
                textBox12.Clear();
                textBox12.AppendText("Player2's Turn");
                play1[1, 0] = 1;
                count++;
            }
            else
            {
                textBox4.AppendText(p2);
                player1 = true;
                player2 = false;
                textBox12.Clear();
                textBox12.AppendText("Player1's Turn");
                play2[1, 0] = 1;
                count++;
            }
            check();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            button5.IsEnabled = false;
            if (player1 == true)
            {
                textBox5.AppendText(p1);
                player1 = false;
                player2 = true;
                textBox12.Clear();
                textBox12.AppendText("Player2's Turn");
                play1[1, 1] = 1; 
                count++;
            }
            else
            {
                textBox5.AppendText(p2);
                player1 = true;
                player2 = false;
                textBox12.Clear();
                textBox12.AppendText("Player1's Turn");
                play2[1, 1] = 1;
                count++;
            }
            check();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            button8.IsEnabled = false;
            if (player1 == true)
            {
                textBox6.AppendText(p1);
                player1 = false;
                player2 = true;
                textBox12.Clear();
                textBox12.AppendText("Player2's Turn");
                play1[1, 2] = 1;
                count++;
            }
            else
            {
                textBox6.AppendText(p2);
                player1 = true;
                player2 = false;
                textBox12.Clear();
                textBox12.AppendText("Player1's Turn");
                play2[1, 2] = 1;
                count++;
            }
            check();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            button9.IsEnabled = false;
            if (player1 == true)
            {
                textBox7.AppendText(p1);
                player1 = false;
                player2 = true;
                textBox12.Clear();
                textBox12.AppendText("Player2's Turn");
                play1[2, 0] = 1;
                count++;
            }
            else
            {
                textBox7.AppendText(p2);
                player1 = true;
                player2 = false;
                textBox12.Clear();
                textBox12.AppendText("Player1's Turn");
                play2[2, 0] = 1;
                count++;
            }
            check();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            button6.IsEnabled = false;
            if (player1 == true)
            {
                textBox8.AppendText(p1);
                player1 = false;
                player2 = true;
                textBox12.Clear();
                textBox12.AppendText("Player2's Turn");
                play1[2, 1] = 1;
                count++;
            }
            else
            {
                textBox8.AppendText(p2);
                player1 = true;
                player2 = false;
                textBox12.Clear();
                textBox12.AppendText("Player1's Turn");
                play2[2, 1] = 1;
                count++;
            }
            check();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            button7.IsEnabled = false;
            if (player1 == true)
            {
                textBox9.AppendText(p1);
                player1 = false;
                player2 = true;
                textBox12.Clear();
                textBox12.AppendText("Player2's Turn");
                play1[2, 2] = 1;
                count++;
            }
            else
            {
                textBox9.AppendText(p2);
                player1 = true;
                player2 = false;
                textBox12.Clear();
                textBox12.AppendText("Player1's Turn");
                play2[2, 2] = 1;
                count++;
            }
            check();
        }

        void check()
        {
            if (((play1[0, 0] == 1) && (play1[0, 1] == 1) && (play1[0, 2] == 1)) ||
                ((play1[1, 0] == 1) && (play1[1, 1] == 1) && (play1[1, 2] == 1)) ||
                ((play1[2, 0] == 1) && (play1[2, 1] == 1) && (play1[2, 2] == 1)) ||
                ((play1[0, 0] == 1) && (play1[1, 0] == 1) && (play1[2, 0] == 1)) ||
                ((play1[0, 1] == 1) && (play1[1, 1] == 1) && (play1[2, 1] == 1)) ||
                ((play1[0, 2] == 1) && (play1[1, 2] == 1) && (play1[2, 2] == 1)) ||
                ((play1[0, 0] == 1) && (play1[1, 1] == 1) && (play1[2, 2] == 1)) ||
                ((play1[0, 2] == 1) && (play1[1, 1] == 1) && (play1[2, 0] == 1)))
            {
                textBox12.Clear();
                textBox12.AppendText("Player1 Wins");
                button1.Content = "Play Again";
                button1.IsEnabled = true;
                Disable_all();
            }

            else if (((play2[0, 0] == 1) && (play2[0, 1] == 1) && (play2[0, 2] == 1)) ||
                ((play2[1, 0] == 1) && (play2[1, 1] == 1) && (play2[1, 2] == 1)) ||
                ((play2[2, 0] == 1) && (play2[2, 1] == 1) && (play2[2, 2] == 1)) ||
                ((play2[0, 0] == 1) && (play2[1, 0] == 1) && (play2[2, 0] == 1)) ||
                ((play2[0, 1] == 1) && (play2[1, 1] == 1) && (play2[2, 1] == 1)) ||
                ((play2[0, 2] == 1) && (play2[1, 2] == 1) && (play2[2, 2] == 1)) ||
                ((play2[0, 0] == 1) && (play2[1, 1] == 1) && (play2[2, 2] == 1)) ||
                ((play2[0, 2] == 1) && (play2[1, 1] == 1) && (play2[2, 0] == 1)))
            {
                textBox12.Clear();
                textBox12.AppendText("Player2 Wins");
                button1.Content = "Play Again";
                button1.IsEnabled = true;
                Disable_all();
            }
            else if (9 == count)
            {
                textBox12.Clear();
                textBox12.AppendText("Match Drawn");
                button1.Content = "Play Again";
                button1.IsEnabled = true;
            }
        }

        
    }
}
