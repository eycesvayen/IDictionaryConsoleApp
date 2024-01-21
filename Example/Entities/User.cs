using Example;

public abstract class User : IUser
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IDNo { get; set; }

    public User() { }
    public User(string userName, string password, bool isActive)
    {
        UserName = userName;
        Password = password;
        IsActive = isActive;
    }

}
