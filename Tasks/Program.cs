Rectangle AreaRectangle = new Rectangle(16, 8);
AreaRectangle.Color = "black";
System.Console.WriteLine($"AreaOfREctangle = {AreaRectangle.GetArea()}");
System.Console.WriteLine($"PerimetrOfRectangle = {AreaRectangle.GetPerimeter()}");

System.Console.WriteLine("------------------");

Circle	AreaCircle = new Circle();
AreaCircle.Radius = 12;
AreaCircle.Color = "yellow";
System.Console.WriteLine($"AreaOfCircle = {AreaCircle.GetArea()}");
System.Console.WriteLine($"PerimeterOfCircle = {AreaCircle.GetCircumference()}");

System.Console.WriteLine("------------------");

Shape ShapeInfo = new Shape();
ShapeInfo.color = "black & red";
ShapeInfo.name = "keyboard";
ShapeInfo.positionX = 18;
ShapeInfo.positionY = 9;
System.Console.WriteLine($"ShapePosition: ");
ShapeInfo.GetPosition();
System.Console.WriteLine();
System.Console.WriteLine($"ShapeFullInfo:");
ShapeInfo.GetFullInfo();