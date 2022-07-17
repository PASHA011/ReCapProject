using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.CTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   
    public class CarManager : ICarService
    {
        ICarDal _efCarDal;
        IColorService _colorService;
        IBrandService _brandService;
        public CarManager(ICarDal carDal,IColorService colorService,IBrandService brandService)
        {
            _efCarDal = carDal;
            _colorService = colorService;
            _brandService = brandService;
        }
        public void Add(Car car)
        {
            _efCarDal.Add(car); 
        }

        public void Delete(Car car)
        {
            _efCarDal.Delete(car);
        }

        public List<Car> GetAll(Car car)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetcarDetailDtos()
        {
            return new List<CarDetailDto>(_efCarDal.GetCarDetailDto());
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
