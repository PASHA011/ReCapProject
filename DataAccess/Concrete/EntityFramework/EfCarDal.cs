using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.CTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDto()
        {
            using (ReCapProectContext context = new ReCapProectContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                           on c.CarId equals co.ColorId
                             join b in context.Brands
                             on c.CarId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 ColorName = co.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice

                             };
                return result.ToList();
            }
        }
    }
}
