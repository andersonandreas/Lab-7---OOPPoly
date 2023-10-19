namespace OOPPolymorphism
{
    internal class Ellips : Geometri
    {

        public double A { get; set; }
        public double B { get; set; }

        public Ellips(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Area()
        {
            return Math.PI * A * B;
        }

        public override void PrintArea()
        {
            Console.WriteLine($"Area Ellips: {Math.Round(this.Area(), 2)}");
        }

    }
}
