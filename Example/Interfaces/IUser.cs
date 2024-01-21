public interface IUser
{
    string UserName { get; set; }
    string Password { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    bool IsActive { get; set; }
    string IDNo { get; set; }

}
