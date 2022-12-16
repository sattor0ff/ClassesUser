public class Rectangle{
    public double Width;
    public double Height;
    public string Color;

    public Rectangle(double w, double h)
    {
        Width = w;
        Height = h;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
    public double GetArea()
    {
        return Width * Height;
    }
}