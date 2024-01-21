public interface IPersonal : IUser
{
    string SSN { get; set; }
    decimal Salary { get; set; }

    void CalculateSalary(short workingHours);
}
