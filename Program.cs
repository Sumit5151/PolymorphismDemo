

using PolymorphismDemo;

public class Program
{
    public static void Main()
    {
        //Doctor doctor = new Doctor();
        //doctor.Operations("Heart Surgery");


        //Arithmetic arithmetic = new Arithmetic();
        //arithmetic.Add();
        //arithmetic.Add(10);
        //arithmetic.Add(10.5f, 20);
        //arithmetic.Add(10.0F, 20.5f);
        //arithmetic.Add(10, 20);
        //arithmetic.Add(20.5f, 10);
        //arithmetic.Add(20, 20);
        //arithmetic.Add(10, 20.5f);






        //Q what is variable , instace and reference?

        Parent parent = new Parent();
        Child child = new Child();

        Parent P;
        Child C;


        //   P = child;

        //P.Show();
        //P.Display();
        //P.Show(10);
        
        

       









        child.Show();//  Parent class show method        
        child.Show(10);//Child Class Show Method

        child.Display();// Child class Display method


       
        parent.Show();  //Parent class show method

        parent.Display();// Parent class dispaly Method

        parent.PutData(); //parent class putdata method

        child.PutData();//child class putdata mehtod.









    }
}