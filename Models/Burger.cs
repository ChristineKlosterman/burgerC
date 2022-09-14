// using System.ComponentModel.DataAnnotations;
namespace burgerC.Models
{

    public class Burger
    {
        public Burger(string bun, int patties, string cheese, bool lettuce, bool pickles, bool onions, bool tomatoes, bool mushrooms, bool peanutbutter, bool sauce)
        {
            Bun = bun;
            Patties = patties;
            Cheese = cheese;
            Lettuce = lettuce;
            Pickles = pickles;
            Onions = onions;
            Tomatoes = tomatoes;
            Mushrooms = mushrooms;
            PeanutButter = peanutbutter;
            Sauce = sauce;
        }

        public Burger()
        {

        }

        public string Bun { get; set; }
        public int Patties { get; private set; }
        public string Cheese { get; set; }
        public bool? Lettuce { get; set; }
        public bool? Pickles { get; set; }
        public bool? Onions { get; set; }
        public bool? Tomatoes { get; set; }
        public bool? Mushrooms { get; set; }
        public bool? PeanutButter { get; set; }
        public bool? Sauce { get; set; }

    }
}