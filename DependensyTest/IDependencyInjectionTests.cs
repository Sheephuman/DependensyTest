    using System.Text.RegularExpressions;

    namespace DependensyTest
    {

    public interface IDependencyInjectionTests
    {
        public string 羊を追い込む処理(string sheeps);

        public int 羊を追い込んだ数をカウントする(string sheeps);
    }


    public class TestService : IDependencyInjectionTests
            {
     

                public int 羊を追い込んだ数をカウントする(string sheeps)
                {
                    string matchPattern = "sheep";
                    int count = Regex.Matches(sheeps, matchPattern).Count;

                    return count;
                }

                public string 羊を追い込む処理(string sheeps)
                {
                    return sheeps.Replace("sheep", "| sheep |");
                }

            }
        
        

    }
