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

            string res = injectionTests.羊を追い込む処理(corralsheepText.Text);

           
            MessageBox.Show(res.ToString());
            

        }

        private void testExecute2_Click(object sender, RoutedEventArgs e)
        {
            //interfaceを介してクラス読み込み
            IDependencyInjectionTests interLayer = new TestService();
           
            //通常のインスタンス作成
            羊を囲い込むクラス injector = new 羊を囲い込むクラス();

            //メソッドの引数でInterfaceLayerをインジェクション
            injector.SetDependency(interLayer);

            var res = injector.tester2(corralsheepText.Text);
            MessageBox.Show(res.ToString());
        }

        private void testExecute3_Click(object sender, RoutedEventArgs e)
        {
            //interfaceを介してクラス読み込み
            IDependencyInjectionTests interLayer = new TestService();
            //通常のインスタンス作成
            羊を囲い込むクラス injector = new 羊を囲い込むクラス();

            injector.IDProperty = interLayer;

            var res = injector.tester2(corralsheepText.Text);
            MessageBox.Show(res.ToString());
        }
    }
}