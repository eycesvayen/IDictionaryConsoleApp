public interface IStudent : IUser
{
    int Absenteeism { get; set; }
    byte Marks { get; set; }
    string StudentNo { get; set; }
}
