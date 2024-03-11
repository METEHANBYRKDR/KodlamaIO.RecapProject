using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace CarConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //CarDetailsTest();

        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Araba Adı:" + " " + car.CarName + " " + "Araba Markası:" + " " + car.BrandName + " " + "Araba Rengi:" + " " + car.ColorName);

            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("Tüm araba bilgileri" + " :" + item.Id + " " + item.Description);
            }

            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Markalarına göre araba bilgileri" + " :" + item.Id + " " + item.Description);
            }

            foreach (var item in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("Renklerine göre araba bilgileri" + " :" + item.Id + " " + item.Description);
            }
        }
    }
}