
using System.Collections.Generic;
using burgerC.Models;

namespace burgerC.db
{
    public static class Db
    {
        public static List<Burger> Burgers { get; set; } = new List<Burger>(){
            new Burger("Sourdough", 2, "cheddar", false, true, true, false, true, true, true),
            new Burger("gluten free", 1, "swiss", true, false, true, true, false, false, false),
        };
    }
}