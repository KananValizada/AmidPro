using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
    }
    public class CarRepository :ICarRepository
    {
        private readonly AmidDbContext _context;
        public CarRepository(AmidDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Car> GetCars()
        {
            return _context.Cars.ToList();
        }
    }
}
