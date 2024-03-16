using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {

        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        List<Brand> GetAll();

        Brand GetById(int brandId);
    }
}
