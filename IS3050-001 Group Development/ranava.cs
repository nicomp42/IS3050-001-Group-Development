using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS3050_001_Group_Development
{
    internal class ranava
    {
        public class HalloweenGreeting
        {
            public void HappyHalloween()
            {
                string name = "Vanshika"; 
                string favoriteCandy = "Twix"; 
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
