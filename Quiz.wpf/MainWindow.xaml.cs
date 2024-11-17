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

namespace Quiz.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            txbFeedback.Background = Brushes.Transparent;
            txbFeedback.Text = string.Empty;    
            if (cmbUserSelection.SelectedItem != null)
            {
                QuizWindow quizWindow = new QuizWindow();
                quizWindow.Show();
            }
            else
            {
                txbFeedback.Text = "Selecteer een speler om te quizzen";
                txbFeedback.Background = Brushes.Red;
            }
        }
    }
}