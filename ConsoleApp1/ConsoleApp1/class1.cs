

internal class myclass
{

    int a;
    int b;
    int c;

    public myclass()
    {
        Console.WriteLine("MY CONSTRUCTORS" + c);
        a = 10;
        b = 20;
    }

    public void addvalues()
    {
        c = a + b;
        Console.WriteLine("the sum is : " + c);
    }

  

     static void Main(string[] args)
    {
         myclass x = new myclass();
        x.addvalues();
         
        
    }
}