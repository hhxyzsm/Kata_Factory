using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            fruit f = Factory.getInstance("Orange");
            f.eat();
            Console.ReadKey();
        }
    }
    public interface fruit
    {

        void eat();
    }



    public class Apple : fruit
    {

        public void eat()
        {
            Console.WriteLine("Apple");
        }

    }

 

public class Orange : fruit
{
    public  void eat()
    {
        Console.WriteLine("Orange");
    }

}

 

// 构造工厂类

// 也就是说以后如果我们在添加其他的实例的时候只需要修改工厂类就行了

public class Factory{

    public static fruit getInstance(String fruitName){

        fruit f=null;
        switch(fruitName)
        {
            case "Apple" :
                f=new Apple();
                break;
            case "Orange" :
                f=new Orange();
                break;
            default:                    
            break;
        
        }
        return f;

    }

}
}
