using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

    public IResult Add(Car car)
    {
        if (car.CarName.Length < 2)
        {
            return new ErrorResult(Messages.CarNameInvalid);
        }

        _carDal.Add(car);
        return new SuccessResult(Messages.CarAdded);
    }

    public IResult Delete(Car car)
    {
        if (car == null)
        {
            return new ErrorResult(Messages.CarNotFound);
        }
        _carDal.Delete(car);
        return new SuccessResult(Messages.CarDeleted);

    }
    public IResult Update(Car car)
    {
        var existingCar = _carDal.Get(c => c.Id == car.Id);

        if (existingCar == null)
        {
            return new ErrorResult(Messages.CarNotFound);
        }

        if (car.CarName.Length < 2)
        {
            return new ErrorResult(Messages.CarNameInvalid);
        }

        _carDal.Update(car);
        return new SuccessResult(Messages.CarUpdated);
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
