using System;
using System.Collections.Generic;
using burgerC.db;
using burgerC.Models;

namespace burgerC.Repositories
{

    public class BurgersRepository
    {

        internal List<Burger> GetBurgers()
        {
            return Db.Burgers;
        }
    }
}