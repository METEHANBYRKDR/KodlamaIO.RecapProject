using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICarDal
{
    List<Car> GetAll();
    void Add(Car car);
    void Update(Car car);

    List<Car> GetById(int id);
    void Delete(Car car);
}
