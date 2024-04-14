using System.Windows;


namespace DependensyTest
{



    public class 羊を囲い込むクラス : IDependencyInjectionTests
    {
        public 羊を囲い込むクラス(IDependencyInjectionTests _injection)
        {

            testInjection = _injection;
            

        }
        public 羊を囲い込むクラス()
        {
          

        }
        

        public void SetDependency(IDependencyInjectionTests dependency)
        {        

            testInjection = dependency;
        }

        private IDependencyInjectionTests? testInjection;
        
        public IDependencyInjectionTests IDProperty
        {
            get
            { if (testInjection == null) throw new InvalidOperationException();
                return testInjection;
            }
            set
            {
                testInjection = value;
            }
        }
        
      

        public string 羊を追い込む処理(string sheeps)
        {
            if (testInjection == null) throw new ArgumentNullException("");
            return testInjection.羊を追い込む処理(sheeps);
        }

        public int tester2(string sheeps)
        {

            if (testInjection == null) throw new ArgumentNullException("");
            return testInjection.tester2(sheeps);
        }
    }
}