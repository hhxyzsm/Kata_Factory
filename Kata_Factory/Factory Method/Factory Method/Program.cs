using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Driver driver = new BenzDriver();//每个具体的工厂类只能创建一个具体实例。

                Car car = driver.driverCar();
                car.drive();
                Console.ReadKey();
            }
            catch (Exception e)
            { } 

        }
    }
    public interface Driver//一个抽象工厂，可以派生出多个具体工厂
    {
         Car driverCar();
    }
    public class BenzDriver : Driver
    {
        public  Car driverCar()
        {
            return new Benz();
        }
    }
    public class BmwDriver : Driver
    {
        public Car driverCar()
        {
            return new Bmw();
        }
    }
}
