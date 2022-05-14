using System;

namespace FamousDesignPattern.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICook meal = new Pizza(); 
            meal.PrepareMeal();
            meal.PresentMeal();


        }

        public interface ICook {
            void PrepareMeal();
            void PresentMeal();
        }

        public class Pizza : ICook
        {
            public void PrepareMeal()
            {
                Console.WriteLine("Pizza Preparing...");
            }

            public void PresentMeal()
            {
                Console.WriteLine("Here's Your Pizza");
            }
        }

        public class Hamburger : ICook
        {
            public void PrepareMeal()
            {
                Console.WriteLine("Hamburger Preparing...");
            }

            public void PresentMeal()
            {
                Console.WriteLine("Here's Your Hamburger");
            }
        }


        public class HotDog : ICook
        {
            public void PrepareMeal()
            {
                Console.WriteLine("HotDog Preparing...");
            }

            public void PresentMeal()
            {
                Console.WriteLine("Here's Your HotDog");
            }
        }

    }
}
