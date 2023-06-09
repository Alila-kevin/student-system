internal class Program
{
    private static void Main(string[] args)
    {
        admission newstd = new admission();
        Console.WriteLine("Enter the details of the new student as per below instraction");
        Console.WriteLine("________________________________________________________________________________");
        Console.WriteLine("enter the admission number (must be a numer 1-9)!!");
        newstd.adm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the fullname of the new student");
        string? n = Console.ReadLine();
        newstd.name = n;
        Console.WriteLine("Enter the gender male/female of the new student");
        string? g = Console.ReadLine();
        newstd.gender = g;
        Console.WriteLine("enter the form of the new student (must me number 1-9)!!");
        newstd.form = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the stream of the new student");
        string? s = Console.ReadLine();
        newstd.stream = s;
        Console.WriteLine("Enter the Domitory of the new student");
        string? d = Console.ReadLine();
        newstd.dom = d;
        Console.WriteLine("Enter the class teacher of the new student");
        string? ct = Console.ReadLine();
        newstd.classteacher = ct;
        Console.WriteLine("Enter the subjects of the new student");
        string? su = Console.ReadLine();
        newstd.subjects = su;
        Console.WriteLine("--------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!---------");
        Console.WriteLine($"--------------Now welcome {newstd.name} in this learning environment---------");
        Console.WriteLine("--------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!---------");
        Console.WriteLine("                                                                                    ");
        Console.WriteLine("                                                                                    ");
        Console.WriteLine("                                                                                    ");
        Console.WriteLine("                                                                                    ");

        //display the inputs
        Console.WriteLine("---@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@---");
        Console.WriteLine($"--          Below are the  details of a new student                              ---");
        Console.WriteLine("---###############################################################################---");
        Console.WriteLine($"admission no. {newstd.adm}");
        Console.WriteLine($"Fullname: {newstd.name}");
        Console.WriteLine($"Gender: {newstd.gender}");
        Console.WriteLine($"form:{newstd.form}-{newstd.stream}");
        Console.WriteLine($"Classteacher: {newstd.classteacher}");
        Console.WriteLine($"Domitory: {newstd.dom}");
        Console.WriteLine($"subjects:  {newstd.subjects}");

        Console.WriteLine($"Take {newstd.name} around the school");

    }
}
public class student
{
    public string gender;
    public string name;
    
    public int adm { get; set; }

}
public class admission : student
{
    public int form;
    public string stream;
    public string dom;
    public string subjects;
    public string classteacher;
    
}