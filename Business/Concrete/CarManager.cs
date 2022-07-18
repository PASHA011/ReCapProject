using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        public CarManager(ICarDal carDal, IColorService colorService, IBrandService brandService)
        {
            _efCarDal = carDal;
            _colorService = colorService;
            _brandService = brandService;
        }
        public IResult Add(Car car)
        {
            _efCarDal.Add(car);
            return new SuccessResult(Message.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _efCarDal.Delete(car);
            return new SuccessResult(Message.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_efCarDal.GetAll());
        }

        public IDataResult<List<CarDetailDto>> GetcarDetailDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_efCarDal.GetCarDetailDto());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            _efCarDal.Update(car);
            return new SuccessResult();
        }
    }
}
