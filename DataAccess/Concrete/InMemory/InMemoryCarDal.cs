using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id = 1,BrandId=1,ColorId=1,DailyPrice=1000,ModelYear=1960,Description="BMW"},
                new Car{ Id = 2,BrandId=1,ColorId=2,DailyPrice=2000,ModelYear=1920,Description="BMW"},
                new Car{ Id = 3,BrandId=2,ColorId=3,DailyPrice=3000,ModelYear=1930,Description="AUDI"},
                new Car{ Id = 4,BrandId=2,ColorId=3,DailyPrice=4000,ModelYear=1940,Description="AUDI"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _cars.SingleOrDefault(p=>p.Id == car.Id);
        //    _cars.Remove(carToDelete);
        //}

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
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
            return _cars.Where(p=> p.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
        }
    }
}
