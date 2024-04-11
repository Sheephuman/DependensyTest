using System.Windows;

namespace DependensyTest
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

        private void testExecute_Click(object sender, RoutedEventArgs e)
        {

            IDependencyInjectionTests inject = new TestService();


            var injectionTests = new 羊を囲い込むクラス(inject);

            string res = injectionTests.tester2(corralsheepText.Text);

           
            MessageBox.Show(res.ToString());
            

        }
    }
}