namespace OOPPolymorphism
{
    class Fyrkant : Geometri
    {

        public double OneSide { get; set; }

        public Fyrkant(double oneSide)
        {
            OneSide = oneSide;

        }

        public override double Area()
        {
            return Math.Pow(OneSide, 2);
        }

        public override void PrintArea()
        {
            Console.WriteLine($"Area Fyrkant: {this.Area()}");
        }
    }
}


