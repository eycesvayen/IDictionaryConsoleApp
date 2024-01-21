using Example;

public class Student : User, IStudent
{
    public int Absenteeism { get; set; }
    public byte Marks { get; set; }
    public string StudentNo { get; set; }

    public Student() { }
    public Student(string userName, string password, bool isActive, int absenteeism, byte marks) : base(userName, password, isActive)
    {
        Absenteeism = absenteeism;
        Marks = marks;
    }
}
