namespace DependensyTest
{
  


    public class 羊を囲い込むクラス
    {
        public 羊を囲い込むクラス(IDependencyInjectionTests _injection)
        {

            testInjection = _injection;
        }


        private IDependencyInjectionTests testInjection;


        public int tester(string sheeps)
        {
            return testInjection.羊を追い込んだ数をカウントする(sheeps);

        }
        public string tester2(string sheeps)
        {
            return testInjection.羊を追い込む処理(sheeps);

        }


    }
}