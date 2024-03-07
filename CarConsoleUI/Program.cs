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
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("Tüm araba bilgileri" +" :" +item.Id + " " + item.Description);
            }

            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Markalarına göre araba bilgileri" +" :"+ item.Id + " " + item.Description);
            }

            foreach (var item in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("Renklerine göre araba bilgileri"+" :"+item.Id + " " + item.Description);
            }

        }
    }
}