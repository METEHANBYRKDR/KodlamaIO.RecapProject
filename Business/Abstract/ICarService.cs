using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetAll();
    List<Car> GetById(int id);
    List<Car> GetCarsByBrandId(int  brandId);
    List<Car> GetCarsByColorId(int colorId);
    List<CarDetailDto> GetCarDetails(); 
    
    IResult Add(Car car);
    IResult Update(Car car);
    IResult Delete(Car car);




}
