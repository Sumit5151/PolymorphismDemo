

using PolymorphismDemo;

public class Program
{
    public static void Main()
    {
        Doctor doctor = new Doctor();
        doctor.Operations("Heart Surgery");


        Arithmetic arithmetic = new Arithmetic();
        arithmetic.Add();
        arithmetic.Add(10);
        arithmetic.Add(10.5f, 20);
        arithmetic.Add(10.0F, 20.5f);
        arithmetic.Add(10, 20);
        arithmetic.Add(20.5f, 10);
        arithmetic.Add(20, 20);
        arithmetic.Add(10, 20.5f);


        Child child = new Child();
        child.Show();
        child.Show(10);


        Parent parent = new Parent();
        parent.Show();

    }
}