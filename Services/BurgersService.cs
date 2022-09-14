using System.Collections.Generic;
using burgerC.Models;
using burgerC.Repositories;

namespace burgerC.Services
{
    public class BurgersService
    {
        private readonly BurgersRepository _burgerRepo;

        public BurgersService(BurgersRepository burgerRepo)
        {
            _burgerRepo = burgerRepo;
        }

        internal List<Burger> GetBurgers()
        {
            List<Burger> burgers = _burgerRepo.GetBurgers();
            return burgers;
        }
    }
}
