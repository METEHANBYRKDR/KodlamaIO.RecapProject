using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {

        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
        List<Color> GetAll();
        Color GetColorById(int colorId);
    }
}
