using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Entities.Concrete.Color color)
        {
            if (color.Name.Length < 2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);
            }

            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Entities.Concrete.Color color)
        {
            if (color == null)
            {
                return new ErrorResult(Messages.ColorNotFound);
            }
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }
        public IResult Update(Entities.Concrete.Color color)
        {
            var existingColor = _colorDal.Get(c => c.Id == color.Id);

            if (existingColor == null)
            {
                return new ErrorResult(Messages.ColorNotFound);
            }

            if (color.Name.Length < 2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);
            }

            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

        public List<Entities.Concrete.Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Entities.Concrete.Color GetColorById(int colorId)
        {
            return _colorDal.Get(k=>k.Id == colorId);
        }

    }
}
