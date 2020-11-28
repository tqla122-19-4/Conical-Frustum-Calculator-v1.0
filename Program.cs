using System;

namespace ooplab2
{

    class Program
    {
        static void Main(string[] args)
        {
            
            var cf = new ConicalFrustum();
            cf.radius1(); cf.radius2();
            cf.hight(); cf.Volume();

            Console.ReadLine();
        }
    }
}
