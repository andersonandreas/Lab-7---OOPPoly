namespace OOPPolymorphism
{
    class Parallellogram : Geometri
    {

        public double TheBase { get; set; }
        public double Height { get; set; }


        public Parallellogram(double theBase, double height)
        {

            TheBase = theBase;
            Height = height;

        }


        public override double Area()
        {
            return TheBase * Height;
        }

        public override void PrintArea()
        {
            Console.WriteLine($"Area Parallellogram: {this.Area()}");
        }


    }
}
