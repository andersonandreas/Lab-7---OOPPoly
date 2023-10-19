namespace OOPPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri cirkel1 = new Cirkel(5);
            cirkel1.PrintArea();

            Geometri fyrkant1 = new Fyrkant(4);
            fyrkant1.PrintArea();

            Geometri rektangel = new Rektangel(10, 4);
            rektangel.PrintArea();

            Geometri parallellogram1 = new Parallellogram(3, 0.9);
            parallellogram1.PrintArea();

            Geometri ellips1 = new Ellips(5, 4);
            ellips1.PrintArea();


        }
    }
}