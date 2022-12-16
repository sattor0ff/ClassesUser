public class Circle {
        public int Radius;
        public const double PI=3.14;
        public string Color;
        public double GetArea() {
            double area;
            area = PI * (Radius * Radius);
            return area;
        }
        public double GetCircumference() {
            double perimeter = (PI * Radius) * 2;
            return perimeter;
        }
    }