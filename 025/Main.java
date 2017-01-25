
 @Deprecated
public class Main
{
    private String myName;
    private gui.View view;
    /**
    * Constructor for objects of class Main
    */
   
    public Main()
    {
        myName = "John Smith";
        main(new String[0]);
        view = new gui.View();

    }

    public static void main(String[] args)
    {
        System.out.println("Hello World");
        bobs();
        new gui.View();

    }

    private static void bobs()
    {
        System.out.println("Bobs");
        new Numbers();
    }
}
