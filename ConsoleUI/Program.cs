using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDetailTest();
        }
        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal(),new ColorManager(new EfColorDal()),new BrandManager(new EfBrandDal()));
            var result = carManager.GetcarDetailDtos();
            foreach (var car in result)
            {
                Console.WriteLine(car.CarName+":"+car.ColorName+"/"+car.BrandName+"/"+car.DailyPrice);
            }
        }
    }
}
