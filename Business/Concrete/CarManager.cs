using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class CarManager : ICarService
{
    ICarDal _carDal;
    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public void Add(Car car)
    {
        _carDal.Add(car);
    }

    public void Delete(Car car)
    {
        _carDal.Delete(car);
    }
    public void Update(Car car)
    {
        _carDal.Update(car);
    }

    public List<Car> GetAll()
    {
        return _carDal.GetAll();
    }

    public List<Car> GetById(int id)
    {
        // Id == CarId entitilerde hata yapmışım
        return _carDal.GetAll(k=>k.Id == id);
    }

    public List<Car> GetCarsByBrandId(int brandId)
    {
        return _carDal.GetAll(k => k.BrandId == brandId);
    }

    public List<Car> GetCarsByColorId(int colorId)
    {
        return _carDal.GetAll(k => k.ColorId == colorId);
    }

    public List<CarDetailDto> GetCarDetails()
    {
       return _carDal.GetCarDetails();
    }
}
