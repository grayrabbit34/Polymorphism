using System;
namespace Polymorphism
{
    public class BaseGeometrikSekil
    {

        private double _width; //fields

        private double _height;

        public double Width //property for Width
        {
            get { return _width; }

            set // set Width a value only if its positive number
            {
                if (value > 0)
                    _width = value;
                else
                {
                    Console.WriteLine("Pozitif bir sayı giriniz.");
                }
            }
        }


        public double Height
        {
            get { return _height; }

            set
            {
                if (value > 0)
                    _height = value;
                else
                    Console.WriteLine("Pozitif bir sayı giriniz.");
            }
        }

        public virtual void AlanHesapla()
        {
            double alan = Width * Height;
            Console.WriteLine($"Şeklin alanı: {alan}");
        }
    }

    public class Square : BaseGeometrikSekil
    {

    }

    public class Rectangle : BaseGeometrikSekil
    {

    }


    public class RightTriangle : BaseGeometrikSekil
    {
        public override void AlanHesapla()
        {
            double alan = Width * Height / 2;
            Console.WriteLine($"Şeklin alanı: {alan}");
        }

    }
}

