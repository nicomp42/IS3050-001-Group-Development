using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS3050_001_Group_Development
{
    internal class painjavv
    {
        public class HalloweenGreeting
        {
            public void HappyHalloween()
            {
                string name = "Vish"; // Replace with your actual name
                string favoriteCandy = "Your Favorite Candy"; // Replace with your favorite candy
                Console.WriteLine($"Happy Halloween! My name is {name} and my favorite candy is {favoriteCandy}.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                HalloweenGreeting greeting = new HalloweenGreeting();
                greeting.HappyHalloween();
            }
        }
    }
}
