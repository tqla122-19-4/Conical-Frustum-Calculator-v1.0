using System;
using System.Collections.Generic;
using System.Text;

namespace ooplab2
{
    class ConicalFrustum
    {
        public static double r1 { get; set; }
        public static double r2 { get; set; }
        public static double h { get; set; }


        public void radius1()
        {
            Console.WriteLine("Введите больший радиус усеченного конуса");
            r1 = Convert.ToDouble(Console.ReadLine());
        }

        public void radius2()
        {
            Console.WriteLine("Введите меньший радиус усеченного конуса");
            r2 = Convert.ToDouble(Console.ReadLine());
        }

        public void hight()
        {
            Console.WriteLine("Введите высоту усеченного конуса");
            h = Convert.ToDouble(Console.ReadLine());
        }

        public void Volume()
        {
            double V = (Math.PI * h * (r1 * r1 + r1 * r2 + r2 * r2)) / 3;
            Console.WriteLine("Объём усеченного конуса = {0}", V);
        }

        ~ConicalFrustum()
        {
            Console.WriteLine("Dispose ConicalFrustum");
        }
    }
}
