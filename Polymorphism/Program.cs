using Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();

        square.Width = 23.5;
        square.Height = 34.67;

        square.AlanHesapla();


        Rectangle rectangle = new Rectangle();

        rectangle.Height = 5;
        rectangle.Width = 15;

        rectangle.AlanHesapla();

        RightTriangle rightTriangle = new RightTriangle();

        rightTriangle.Height = 5;
        rightTriangle.Width = 45;

        rightTriangle.AlanHesapla();
    }

}