using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework5_Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        static Random generator = new Random();
        static int num = generator.Next(101);
        static int numGuess = 0;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double guess = Convert.ToDouble(text.Text);

            if (guess < num)
            {
                result.Content = "Guess too low!";
                numGuess++;
            }
            else if (guess > num)
            {
                result.Content = "Guess too high!";
                numGuess++;
            }
            else {
                numGuess++;
                result.Content = "Correct!\n"+numGuess+" guesses taken!";
            }
        }
    }
}