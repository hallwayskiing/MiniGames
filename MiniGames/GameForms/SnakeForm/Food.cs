using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames.GameForms
{
    internal class Food
    {
        Label food;

        Size size;

        Random random;

        public Food(Label food,Size size) 
        { 
            this.food = food;
            this.size = size;
            random = new Random();
        }

        public void create()
        {
            food.Location = new Point(random.Next(100,size.Width-100), random.Next(50,size.Height-50));
        }
    }
}
