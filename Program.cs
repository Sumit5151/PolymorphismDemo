


public class Parent
{
    public int Id { get; set; }
    public string Name { get; set; }

    //Default / Paremeterless constructor
    public Parent()
    {
        this.Id = 1;
        this.Name = "Amit";
        Console.WriteLine("Default constructor called");
    }

    //Parameterized constructor
    public Parent(int id, string name)
    {
        this.Id = id;
        this.Name = name;
        Console.WriteLine("Parameterized constructor called");
    }

    public Parent(string name, int id)
    {
        this.Id = id;
        this.Name = name;
        Console.WriteLine("Parameterized constructor called");
    }

    public void Show()
    {

    }
    public void Show(int a, int b)
    {

    }

}


public class Program
{
    public static void Main()
    {
        Parent p = new Parent();
        Parent p2 = new Parent(2, "Vijay");
        Parent p3 = new Parent("Abhijeet", 3);



        Console.WriteLine(p.Id + " " + p3.Name);
        p.Show();
        p.Show(10, 20);
    }
}
