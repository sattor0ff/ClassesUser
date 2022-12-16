public class User
{
    public string FirstName = "ArdasheR";
    public string LastName = "Sattorzoda"; 
    public string UserName = "sattor0ff"; 
    public string Password = "ardash";
    public bool IsLoggedOn;

     public void Login(string username, string password)
     {
        if(username == UserName && password == Password)
        {
            System.Console.WriteLine("User logged successfully");
            IsLoggedOn = true;
        }
        else
        {
            System.Console.WriteLine("Your password or username is incorrect");
        }
     }
     public void LogOut()
     {
        IsLoggedOn = false;
     }
     public string GetFullInfo()
     {
        return $"{FirstName} {LastName} - {IsLoggedOn}";
     }
}