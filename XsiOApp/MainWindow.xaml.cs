using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XsiOApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int whoseTurn = 1;  //a cui ii e randul
        double playerOneScore = 0;
        double playerTwoScore = 0;
        public MainWindow()
        {
            InitializeComponent();
            turnLabelManager();
        }
        private void turnLabelManager()
        {
            if (whoseTurn == 1) 
            {
                Player1TurnLabel.Visibility = Visibility.Visible;
                Player2TurnLabel.Visibility = Visibility.Hidden;
            }
            if (whoseTurn == 2)
            {
                Player2TurnLabel.Visibility = Visibility.Visible;
                Player1TurnLabel.Visibility = Visibility.Hidden;
            }
        }
        private void resetGame()
        {
            TopLeftButton.Content = null;
            TopButton.Content = null;
            TopRightButton.Content = null;
            LeftButton.Content = null;
            MiddleButton.Content = null;
            RightButton.Content = null;
            BottomLeftButton.Content = null;
            BottomButton.Content = null;
            BottomRightButton.Content = null;
        }

        private void checkGame()
        {
            if (TopLeftButton.Content == TopButton.Content && TopButton.Content == TopRightButton.Content && TopLeftButton.Content != null && TopButton.Content != null && TopRightButton.Content != null)
            {
                if (whoseTurn == 1)
                {
                    //player 1 wins
                    playerOneScore++;
                    Player1ScoreLabel.Content = playerOneScore;
                    resetGame();
                }
                else if (whoseTurn == 2)
                {
                    //player 2 wins
                    playerTwoScore++;
                    Player2ScoreLabel.Content = playerTwoScore;
                    resetGame();
                }
            }
            else if (LeftButton.Content == MiddleButton.Content && MiddleButton.Content == RightButton.Content && LeftButton.Content != null && MiddleButton.Content != null && RightButton.Content != null)
            {
                if (whoseTurn == 1)
                {
                    //player 1 wins
                    playerOneScore++;
                    Player1ScoreLabel.Content = playerOneScore;
                    resetGame();
                }
                else if (whoseTurn == 2)
                {
                    //player 2 wins
                    playerTwoScore++;
                    Player2ScoreLabel.Content = playerTwoScore;
                    resetGame();
                }
            }
            else if (BottomLeftButton.Content == BottomButton.Content && BottomButton.Content == BottomRightButton.Content && BottomLeftButton.Content != null && BottomButton.Content != null && BottomRightButton.Content != null)
            {
                if (whoseTurn == 1)
                {
                    //player 1 wins
                    playerOneScore++;
                    Player1ScoreLabel.Content = playerOneScore;
                    resetGame();
                }
                else if (whoseTurn == 2)
                {
                    //player 2 wins
                    playerTwoScore++;
                    Player2ScoreLabel.Content = playerTwoScore;
                    resetGame();
                }
            }
            else if (TopLeftButton.Content == LeftButton.Content && LeftButton.Content == BottomLeftButton.Content && TopLeftButton.Content != null && LeftButton.Content != null && BottomLeftButton.Content != null)
            {
                if (whoseTurn == 1)
                {
                    //player 1 wins
                    playerOneScore++;
                    Player1ScoreLabel.Content = playerOneScore;
                    resetGame();
                }
                else if (whoseTurn == 2)
                {
                    //player 2 wins
                    playerTwoScore++;
                    Player2ScoreLabel.Content = playerTwoScore;
                    resetGame();
                }
            }
            else if (TopButton.Content == MiddleButton.Content && MiddleButton.Content == BottomButton.Content && TopButton.Content != null && MiddleButton.Content != null && BottomButton.Content != null)
            {
                if (whoseTurn == 1)
                {
                    //player 1 wins
                    playerOneScore++;
                    Player1ScoreLabel.Content = playerOneScore;
                    resetGame();
                }
                else if (whoseTurn == 2)
                {
                    //player 2 wins
                    playerTwoScore++;
                    Player2ScoreLabel.Content = playerTwoScore;
                    resetGame();
                }
            }
            else if (TopRightButton.Content == RightButton.Content && RightButton.Content == BottomRightButton.Content && TopRightButton.Content != null && RightButton.Content != null && BottomRightButton.Content != null)
            {
                if (whoseTurn == 1)
                {
                    //player 1 wins
                    playerOneScore++;
                    Player1ScoreLabel.Content = playerOneScore;
                    resetGame();
                }
                else if (whoseTurn == 2)
                {
                    //player 2 wins
                    playerTwoScore++;
                    Player2ScoreLabel.Content = playerTwoScore;
                    resetGame();
                }
            }
            else if (TopLeftButton.Content == MiddleButton.Content && MiddleButton.Content == BottomRightButton.Content && TopLeftButton.Content != null && MiddleButton.Content != null && BottomRightButton.Content != null)
            {
                if (whoseTurn == 1)
                {
                    //player 1 wins
                    playerOneScore++;
                    Player1ScoreLabel.Content = playerOneScore;
                    resetGame();
                }
                else if (whoseTurn == 2)
                {
                    //player 2 wins
                    playerTwoScore++;
                    Player2ScoreLabel.Content = playerTwoScore;
                    resetGame();
                }
            }
            else if (TopRightButton.Content == MiddleButton.Content && MiddleButton.Content == BottomLeftButton.Content && TopRightButton.Content != null && MiddleButton.Content != null && BottomLeftButton.Content != null)
            {
                if (whoseTurn == 1)
                {
                    //player 1 wins
                    playerOneScore++;
                    Player1ScoreLabel.Content = playerOneScore;
                    resetGame();
                }
                else if (whoseTurn == 2)
                {
                    //player 2 wins
                    playerTwoScore++;
                    Player2ScoreLabel.Content = playerTwoScore;
                    resetGame();
                }
            }

            //pentru egalitate
            else if (TopLeftButton.Content!=null && TopButton.Content!=null && TopRightButton.Content!=null && LeftButton.Content!=null && MiddleButton.Content!=null && RightButton.Content!=null && BottomLeftButton.Content!=null && BottomButton.Content!=null && BottomRightButton.Content!=null) 
            {
                playerOneScore += 0.5;
                playerTwoScore += 0.5;
                Player1ScoreLabel.Content = playerOneScore;
                Player2ScoreLabel.Content = playerTwoScore;
                resetGame();
            }
        }

        private void TopLeftButton_Click(object sender, RoutedEventArgs e)
        {
            if (TopLeftButton.Content == null)
            {
                if (whoseTurn == 1)
                {
                    TopLeftButton.Content = "X";
                    //aici bag check game + break
                    checkGame();
                    whoseTurn = 2;
                }
                else
                {
                    TopLeftButton.Content = "O";
                    checkGame();
                    whoseTurn = 1;
                }
                turnLabelManager();
            }
        }

        private void TopButton_Click(object sender, RoutedEventArgs e)
        {
            if (TopButton.Content == null)
            {
                if (whoseTurn == 1)
                {
                    TopButton.Content = "X";
                    checkGame();
                    whoseTurn = 2;
                }
                else
                {
                    TopButton.Content = "O";
                    checkGame();
                    whoseTurn = 1;
                }
                turnLabelManager();
            }
        }

        private void TopRightButton_Click(object sender, RoutedEventArgs e)
        {
            if (TopRightButton.Content == null)
            {
                if (whoseTurn == 1)
                {
                    TopRightButton.Content = "X";
                    checkGame();
                    whoseTurn = 2;
                }
                else
                {
                    TopRightButton.Content = "O";
                    checkGame();
                    whoseTurn = 1;
                }
                turnLabelManager();
            }
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            if (LeftButton.Content == null)
            {
                if (whoseTurn == 1)
                {
                    LeftButton.Content = "X";
                    checkGame();
                    whoseTurn = 2;
                }
                else
                {
                    LeftButton.Content = "O";
                    checkGame();
                    whoseTurn = 1;
                }
                turnLabelManager();
            }
        }

        private void MiddleButton_Click(object sender, RoutedEventArgs e)
        {
            if (MiddleButton.Content == null)
            {
                if (whoseTurn == 1)
                {
                    MiddleButton.Content = "X";
                    checkGame();
                    whoseTurn = 2;
                }
                else
                {
                    MiddleButton.Content = "O";
                    checkGame();
                    whoseTurn = 1;
                }
                turnLabelManager();
            }
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            if (RightButton.Content == null)
            {
                if (whoseTurn == 1)
                {
                    RightButton.Content = "X";
                    checkGame();
                    whoseTurn = 2;
                }
                else
                {
                    RightButton.Content = "O";
                    checkGame();
                    whoseTurn = 1;
                }
                turnLabelManager();
            }
        }

        private void BottomLeftButton_Click(object sender, RoutedEventArgs e)
        {
            if (BottomLeftButton.Content == null)
            {
                if (whoseTurn == 1)
                {
                    BottomLeftButton.Content = "X";
                    checkGame();
                    whoseTurn = 2;
                }
                else
                {
                    BottomLeftButton.Content = "O";
                    checkGame();
                    whoseTurn = 1;
                }
                turnLabelManager();
            }
        }

        private void BottomButton_Click(object sender, RoutedEventArgs e)
        {
            if (BottomButton.Content == null)
            {
                if (whoseTurn == 1)
                {
                    BottomButton.Content = "X";
                    checkGame();
                    whoseTurn = 2;
                }
                else
                {
                    BottomButton.Content = "O";
                    checkGame();
                    whoseTurn = 1;
                }
                turnLabelManager();
            }
        }

        private void BottomRightButton_Click(object sender, RoutedEventArgs e)
        {
            if (BottomRightButton.Content == null)
            {
                if (whoseTurn == 1)
                {
                    BottomRightButton.Content = "X";
                    checkGame();
                    whoseTurn = 2;
                }
                else
                {
                    BottomRightButton.Content = "O";
                    checkGame();
                    whoseTurn = 1;
                }
                turnLabelManager();
            }
        }

        private void HardResetButton_Click(object sender, RoutedEventArgs e)
        {
            whoseTurn = 1;
            turnLabelManager();
            resetGame();
            playerOneScore = 0;
            playerTwoScore = 0;
            Player1ScoreLabel.Content = playerOneScore;
            Player2ScoreLabel.Content = playerTwoScore;
        }
    }
}
