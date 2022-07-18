using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarDetailTest();
          //  AddToCars();
      //AddUser();
         CustomerUser();
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
            carManager.Add(new Car { CarName="Hyundai",ColorId=1,BrandId=1,DailyPrice=200,ModelYear=2010,Description="Grate car" });
        }
        private static void AddUser()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { Email = "ibo@gmail.com", FirstName = "ibo", LastName = "pasha", Password = "a123" });
        }
        private static void CustomerUser()
        {
            CustomerManager customerManager = new CustomerManager(new EfCusomerDal());
            customerManager.Add(new Customer { UserId=2,CompanyName= "a ŞİRKETİ"});
            
        }
    }
}
