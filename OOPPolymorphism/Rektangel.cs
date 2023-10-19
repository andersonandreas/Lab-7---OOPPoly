namespace OOPPolymorphism
{
    class Rektangel : Geometri
    {
        public double TheBase { get; set; }
        public double Height { get; set; }


        public Rektangel(double theBase, double height)
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
            Console.WriteLine($"Area Rektangel: {this.Area()}");
        }
    }
}
