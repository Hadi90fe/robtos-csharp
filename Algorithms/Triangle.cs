namespace Algorithms;
internal class Triangle

{

    private Point sommet1;
    private Point sommet2;
    private Point sommet3;

 

    public Triangle(Point sommet1,Point sommet2,Point sommet3)
    {
        this.sommet1 = sommet1;
        this.sommet2 = sommet2;
        this.sommet3 = sommet3;
    }

    public static Triangle Equilateral(double longueur)
    {

        Point sommet1 = new Point(0,0);
        Point sommet2 = new Point(0, longueur);

        // H2 = A2 + B2
        // B = sqrt (H2 - A2)

        double x = Math.Sqrt(longueur*longueur - longueur*longueur/4);
        Point sommet3 = new Point(x, longueur/2);
        return new Triangle(sommet1, sommet2, sommet3);
    }

}