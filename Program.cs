


public class Parent
{
    public void Show() { Console.WriteLine("Parent class show method"); }
    public virtual void Display() { Console.WriteLine("Parent class display method"); }
    public void Putdata() { Console.WriteLine("Parent class Putdata method"); }
}


public class Child : Parent
{
    public void Show(int a) { Console.WriteLine("child class show method"); } //method overloading

    public override void Display()//Medhod overriding
    {
        Console.WriteLine("child class dispaly method");
        Parent p = new Parent();
        p.Display();   //calling to Parent class methods
        p.Putdata();  //calling to Parent class methods
    }

    public new void Putdata() //Method Hiding
    {
        Console.WriteLine("child class show Putdata");
        base.Display();//calling to Parent class methods
        base.Putdata();//calling to Parent class methods
    }   
}

public class Program
{
    public static void Main()
    {
        Child c = new Child();
        c.Show();  //Parent class show method
        c.Show(10);//Child class show method
        c.Display();//Child class Display method
        c.Putdata();//Child class Putdata method
        
        Parent p = new Parent();
        p.Show(); //Parnet class show method
        p.Display();//Parnet class show method
        p.Putdata();//Parnet class show method

        //p.Show(10);  //invalid
        Parent parent;
        Child child;

         parent = c;
        //child = p; invalid


        parent.Display();//child class mehtod
        parent.Putdata();//child class mehtod
        //parent.Show(10);  // because this method is purely defined in the child class
        //
        parent = p;
        parent.Display(); //parent class mehtod
        parent.Putdata();//parent class mehtod

    }
}
