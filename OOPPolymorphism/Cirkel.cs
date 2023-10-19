namespace OOPPolymorphism
{
    class Cirkel : Geometri
    {

        public double Radius { get; set; }

        public Cirkel(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {

            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override void PrintArea()
        {

            Console.WriteLine($"Area Cirkel; {Math.Round(this.Area(), 1)}");
        }


    }
}
