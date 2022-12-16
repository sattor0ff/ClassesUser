public class Shape
{
    public string color;
    public string name;
    public int positionX;
    public int positionY;

     public void GetPosition(){
        System.Console.WriteLine($"PositionX = {positionX} PositionY = {positionY}");
     }
     public void GetFullInfo()
     {
        System.Console.WriteLine($"Color = {color} Name = {name} PositionX = {positionX} PositionY = {positionY}");
     }
}