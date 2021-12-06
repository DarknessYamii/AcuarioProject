using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Windows.Threading;
namespace Acuario
{
    /// <summary>
    /// Lógica de interacción para Minijuego.xaml
    /// </summary>
    public partial class Minijuego : Window
    {
        // Timer to control speed 
        DispatcherTimer gameTimer = new DispatcherTimer();
        // Values to increase the difficult
        int speed = 5;
        int intervals = 90;

        Random rand = new Random();

        // List to get every point where a bubble is located and remove it
        List<Rectangle> itemRemover = new List<Rectangle>();

        // Background of Minijuego
        ImageBrush imageBackground = new ImageBrush();

        // Int which content every Bubble skin
        int bubbleSkins;
        int i;
        // Counter of missed bubbles
        int missedBubble;
        // Detect is game is running
        bool gameIsActive;
        // Scoreboard
        int score;

        MediaPlayer sound = new MediaPlayer();
        public Minijuego()
        {
            InitializeComponent();
            // Timer since u click into the game
            gameTimer.Tick += GameEngine;
            // Interval the game runs 
            gameTimer.Interval = TimeSpan.FromMilliseconds(10);
            // Get image background
            imageBackground.ImageSource = new BitmapImage(new Uri("../../../oceano.jpg", UriKind.Relative));
            // Set image background
            MyCanvas.Background = imageBackground;
            // Restart Game 
            RestartGame();
        }
        /**
         * Game Scripts
         * Every function of the game
         */
        private void GameEngine(object sender, EventArgs e)
        {
            // Change Label each time player get point
            scoreText.Content = "Puntuacion: " + score;
            // Reduce Interval = More items on screen
            intervals -= 10;

            if (intervals < 1)
            {
                ImageBrush bubbleImage = new ImageBrush();
                // Get every skins of bubble
                bubbleSkins += 1;

                if (bubbleSkins > 5)
                {
                    // Go to the first skin
                    bubbleSkins = 1;
                }
                // Control every bubble skin, to show into the game
                switch (bubbleSkins)
                {
                    case 1:
                        bubbleImage.ImageSource = new BitmapImage(new Uri("../../../bubbles/bubble1.png", UriKind.Relative));
                        break;
                    case 2:
                        bubbleImage.ImageSource = new BitmapImage(new Uri("../../../bubbles/bubble2.png", UriKind.Relative));
                        break;
                    case 3:
                        bubbleImage.ImageSource = new BitmapImage(new Uri("../../../bubbles/bubble3.png", UriKind.Relative));
                        break;
                    case 4:
                        bubbleImage.ImageSource = new BitmapImage(new Uri("../../../bubbles/bubble4.png", UriKind.Relative));
                        break;
                    case 5:
                        bubbleImage.ImageSource = new BitmapImage(new Uri("../../../bubbles/bubble5.png", UriKind.Relative));
                        break;
                }
                // Transform the Image into a (Object) Rectangle 
                Rectangle newBubble = new Rectangle
                {
                    Tag = "bubble",
                    Height = 70,
                    Width = 50,
                    Fill = bubbleImage
                };
                // Insert item in a random spot
                Canvas.SetLeft(newBubble, rand.Next(50, 400));
                Canvas.SetTop(newBubble, 600);
                MyCanvas.Children.Add(newBubble);
        
                intervals = rand.Next(90, 150);

            }

            // Control the movement of bubble
            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                // Confirm if the rectangle == bubble then do actions
                if ((string)x.Tag == "bubble")
                {
                    // Movement to the left or right
                    i = rand.Next(-5, 5);
                    // Movement to the topside, it depends of speed
                    Canvas.SetTop(x, Canvas.GetTop(x) - speed);
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - (i * -1));
                }
                // Check if bubble go out of the screen
                if (Canvas.GetTop(x) < 20)
                {
                    itemRemover.Add(x);
                    // Count +1 to the missedBubble
                    missedBubble += 1;
                }

            }
            // For each Rectangle(Click) in itemRemover(bubble clicked) 
            foreach (Rectangle y in itemRemover)
            {
                // Remove bubble clicked
                MyCanvas.Children.Remove(y);
            }

            // Check if we losed the game
            if (missedBubble > 10)
            {
                gameIsActive = false;
                gameTimer.Stop();
                MessageBox.Show("Fin del juego, has fallado mas de 10 burbujas" + Environment.NewLine + "Clickea para jugar otra vez");
                // Restart when player click in Accept 
                RestartGame();
            }
            // If Score > 3 + Difficult
            if (score > 3)
            {
                // Increase speed
                speed = 7;
            }

            if(score > 15)
            {
                speed = 10;
            }

        }


        /**
         * Sound control
         */
        private void PopBubbles(object sender, MouseButtonEventArgs e)
        {
            // Check if game is running
            if (gameIsActive)
            {
                    // Check if we clicked on a item
                if (e.OriginalSource is Rectangle)
                {

                    Rectangle activeRec = (Rectangle)e.OriginalSource;
                    // Each click in a item, sound play
                    sound.Open(new Uri("../../../popBubble.mp3", UriKind.RelativeOrAbsolute));
                    sound.Play();

                    MyCanvas.Children.Remove(activeRec);

                    score += 1;
                }
            }
        }
        /**
         * Start game
         * Initial values
         */
        private void StartGame()
        {
            gameTimer.Start();

            missedBubble = 0;
            score = 0;
            intervals = 60;
            gameIsActive = true;
            speed = 5;
        }
        /**
         * Restart game
         * Clear data
         */
        private void RestartGame()
        {
            // Add every bubble created into itemRemover
            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                itemRemover.Add(x);
            }
            // Remove every item added into itemRemover
            foreach (Rectangle y in itemRemover)
            {
                MyCanvas.Children.Remove(y);
            }
            // Clear list
            itemRemover.Clear();

            StartGame();

        }
    }
}
