using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
    IBrandDal _brandDal;
    Brand _existingBrand;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public IResult Add(Brand brand)
    {
        if (brand.Name.Length < 2)
        {
            return new ErrorResult(Messages.BrandNameInvalid);
        }
        _brandDal.Add(brand);
        return new SuccessResult(Messages.BrandAdded);
    }

    public IResult Delete(Brand brand)
    {
        
        if (_existingBrand == null)
        {
            return new ErrorResult(Messages.BrandNotFound);
        }
        _brandDal.Delete(brand);
        return new SuccessResult(Messages.CarDeleted);
    }
    public IResult Update(Brand brand)
    {
        _existingBrand = _brandDal.Get(c => c.Id == brand.Id);
        if (_existingBrand == null)
        {
            return new ErrorResult(Messages.BrandNotFound);
        }

        _brandDal.Update(brand);
        return new SuccessResult(Messages.CarUpdated);
    }

    public List<Brand> GetAll()
    {
        return _brandDal.GetAll();
    }

    public Brand GetById(int brandId)
    {
        return _brandDal.Get(k => k.Id == brandId);
    }

}
