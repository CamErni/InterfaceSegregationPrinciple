public interface IEmployee
{
    public void Work();
    
    public void TimeIn();
}
interface IDestroyUser
{
    void DeleteUser()
    {
        Console.WriteLine("User deleted");
    }
}


interface IManager
{
    void Manage()
    {
        Console.WriteLine("Mischief Managed");
    }
}
public class Manager : IEmployee, IManager, IDestroyUser
{
    //implement interface
    public void Work()
    {
        Console.WriteLine("Manager is working...");
    }
    public void TimeIn()
    {
        Console.WriteLine("Manager timed in.");
    }
    public void DeleteUser()
    {
        Console.WriteLine("Manager deleted User!");
    }
    public void Manage()
    {
        Console.WriteLine("Manager is managing...");
    }
}
public class Employee : IEmployee
{
    //implement interface
    public void Work()
    {
        Console.WriteLine("Employee is working...");
    }
    public void TimeIn()
    {
        Console.WriteLine("Employee timed in.");
    }
}
public class Admin : IEmployee, IDestroyUser, IManager
{
    //implement interface
    public void Work()
    {
        Console.WriteLine("Admin is working...");
    }
    public void TimeIn()
    {
        Console.WriteLine("Admin timed in.");
    }
    public void DeleteUser()
    {
        Console.WriteLine("Admin deleted User!");
    }
    public void Manage()
    {
        Console.WriteLine("Admin is managing...");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        Admin admin = new Admin();
        Manager manager = new Manager();
        emp.TimeIn();
        emp.Work();
        
        admin.TimeIn();
        admin.Work();
        admin.Manage();
        admin.DeleteUser();

        manager.TimeIn();
        manager.Work();
        manager.Manage();
        manager.DeleteUser();   

    }
}