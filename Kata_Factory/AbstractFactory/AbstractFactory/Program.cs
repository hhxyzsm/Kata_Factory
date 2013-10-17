using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory instance = new FactoryA();//每个具体工厂可以创建多个具体产品实例
            plant Plant= instance.CreatPlant();
            Fruit fruta=instance.CreatFruit();
            Plant.DoSomething();
            fruta.DoSomething();
            Console.ReadLine();
        }
    }

    //产品Plant接口
    public interface plant {
        void DoSomething();
    }//标志接口
    //具体产品plantA，plantB
    public class plantA:plant {
        public plantA() {
            Console.WriteLine("Create PlantA!");
        }
        public void DoSomething() {
            Console.WriteLine(" PlantA Do Something!");
        }
    }
    public class plantB : plant
    {
        public plantB()
        {
            Console.WriteLine("Create PlantB!");
        }
        public void DoSomething()
        {
            Console.WriteLine(" PlantB Do Something!");
        }
    }
    //产品Fruit接口
    public interface Fruit { 
     void DoSomething();
    }
    //具体产品FruitA,FruitB
    public class FruitA : Fruit {
        public FruitA() {
            Console.WriteLine("Create FruitA!");
        }
        public void DoSomething() {
            Console.WriteLine("FruitA Do Something...");
        }
    }
    public class FruitB : Fruit
    {
        public FruitB()
        {
            Console.WriteLine("Create FruitB!");
        }
        public void DoSomething()
        {
            Console.WriteLine("FruitB Do Something...");
        }
    }
    //抽象工厂方法
    public interface AbstractFactory {
         plant CreatPlant();
         Fruit CreatFruit();
    }
    //具体工厂方法
    public class FactoryA : AbstractFactory {
        public plant CreatPlant() {
            return new plantA();
        }
        public Fruit CreatFruit() {
            return new FruitA();
        }
    }
    public class FactoryB : AbstractFactory
    {
        public plant CreatPlant()
        {
            return new plantB();
        }
        public Fruit CreatFruit()
        {
            return new FruitB();
        }
    }

}
