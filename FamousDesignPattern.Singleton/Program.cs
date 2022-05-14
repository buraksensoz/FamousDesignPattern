using System;

namespace FamousDesignPattern.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Music.GetInstance();
            var y = Music.GetInstance();
        }
    }

    public class Music
    {
        private static Music music;
        public static Music GetInstance() {
            if (music == null)
            {
                music = new Music();
                Console.WriteLine("New Music Created");
            }
            else
                Console.WriteLine("Music Returned");


            return music;
        
        }


    }
}
