class HelloWorld
{
    static void Main(string[] args)
    {
        var myClass = new MyClass("Ariel");
        Console.WriteLine(myClass.myName);

        //Hola mundo
        Console.WriteLine("Hello, World!");
        
        string myString = "Esto es una cadena de texto";
        Console.WriteLine(myString);

        int myInt = 9;
        myInt = myInt + 4;
        Console.WriteLine(myInt);
        float myFloat = 7.8F;
        Console.WriteLine(myFloat);
        bool myBool = true;
        Console.WriteLine(myBool);
        Console.WriteLine($"El valor de mi string es {myInt}");

        var myArray = new string [] {"Ariel", "Rivas", "Ferri"};
        Console.WriteLine(myArray[0]);

        var myDictionary = new Dictionary<string, int>
        {
            {"Ariel", 29},
            {"Juan", 18},
            {"Ana", 25},
        };
        Console.WriteLine(myDictionary["Ariel"]);

        var mySet = new HashSet<string> {"Ariel", "Rivas", "Ferri"};
        Console.WriteLine(mySet);

        var myTupla = ("Ariel", "Rivas", "Ferri");
        Console.WriteLine(myTupla);

        //Bucles

        for (int i = 0; i < 5; i++)
        {
           Console.WriteLine(i); 
        }

        foreach(var myItem in myArray)
        {
            Console.WriteLine(myItem);
        }

        //Flujos

        if (myInt == 11)
        {
            Console.WriteLine("El valor es 9");
        }
        else if (myInt == 12 || myBool == false)
        {
            Console.WriteLine("El valor es 12");
        }
        else
        {
            Console.WriteLine("El valor es ni 11  ni 12");
        } 
        //Funciones
        MyFunction(); 
        Console.WriteLine(MyFunctionWithReturn(5));   
    }
    
    static void MyFunction()
    {
        Console.WriteLine("Mi función");
    }

    static int MyFunctionWithReturn(int param)
    {
        return 10 + param;
    }
    class MyClass
    {
        public string myName {get; set;}

        public MyClass(string myCurrentName)
        {
            myName = myCurrentName;
        }
    }
}


