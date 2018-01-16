using System;


partial class MainHelper {

    private static MainHelper shared;
    private MainHelper()
    { }

    public static MainHelper getInstance()
    {
        if (shared == null)
            shared = new MainHelper();

        return shared;
    }

}


partial class MainHelper {

    public void Run(String item) 
    {
        Console.WriteLine(item);   
    }

}