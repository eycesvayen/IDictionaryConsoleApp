using Example;

public class Jobber : User, IJobber
{
    public string WorkArea { get; set; }
    public string PlateNo { get; set; }

    public Jobber() { }
    public Jobber(string userName, string password, bool isActive, string workArea) : base(userName, password, isActive)
    {
        WorkArea = workArea;
    }
}
