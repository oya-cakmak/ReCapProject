using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{ 
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice=7900, ModelYear = "2020", Description="BMW"},
                new Car{Id = 2, BrandId = 2, ColorId = 1, DailyPrice=4590, ModelYear = "2018", Description="Skoda"},
                new Car{Id = 3, BrandId = 3, ColorId = 1, DailyPrice=9450, ModelYear = "2016", Description="Mini Cooper"},
                new Car{Id = 4, BrandId = 4, ColorId = 2, DailyPrice=5500, ModelYear = "2017", Description="Audi"},
                new Car{Id = 5, BrandId = 5, ColorId = 2, DailyPrice=9800, ModelYear = "2021", Description="Mercedes"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carsToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carsToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carsToUpdate.BrandId = car.BrandId;
            carsToUpdate.ColorId = car.ColorId;
            carsToUpdate.DailyPrice = car.DailyPrice;
            carsToUpdate.ModelYear = car.ModelYear;
            carsToUpdate.Description = car.Description;
        }
    }
}
