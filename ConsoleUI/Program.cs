using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
              CarDetailTest();
            //AddToCars();
        }
        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal(),new ColorManager(new EfColorDal()),new BrandManager(new EfBrandDal()));
            var result = carManager.GetcarDetailDtos();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName+":"+car.ColorName+"/"+car.BrandName+"/"+car.DailyPrice);
            }
        }
        private static void AddToCars()
        {
        
            CarManager carManager = new CarManager(new EfCarDal(), new ColorManager(new EfColorDal()), new BrandManager(new EfBrandDal()));
            carManager.Add(new Car { CarName="Mercedes",ColorId=1,BrandId=1,DailyPrice=400,ModelYear=2020,Description="Grate car" });
        }

    }
}
