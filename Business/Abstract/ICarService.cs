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
    
    void Add(Car car);
    void Update(Car car);
    void Delete(Car car);




}
