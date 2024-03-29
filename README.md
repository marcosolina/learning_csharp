# Learning C\#

I am a Java certified developer, so my primary language is Java. As a developer I like to continue to learn new things, it is time for me to learn the C# (C Sharp, not C Hash) language.
So... I am reading [this](http://www.csharpcourse.com/) book, and I will put in this repo all the exercises / Notes that I consider important to me.

## Updates
- 2020-11-22 - I have finished the Book. The book gave me an initial high level view of the differences between Java and C#. It is ok as a starting point. I will propably look for a book which goes deeper into the C# world, like the book for the Java OCP exam.

## Book exercises

### Chapter 01

- No exercises, it was just an introduction

### Chapter 02 Notes

- My first C# program
- The file name of the source code does not need to match the class name like in Java. But it is a convention to make it match
- I can define strings using the UNICODE code, for example: "\x0041" is equal to "A". If I don't want to escape the string I can do @"\x0041", this will print \x0041. the @"" is called verbatim string
- You can use the verbatim character to write a string on multiple lines
  
        @"The quick
        brown fox
        jumps over the lazy dog"

### Chapter 03 Notes

- When I call a method, I can change the order of the arguments providing the name of the parameter:value

        static double readValue(string prompt, double low, double hight){...}
        x = readValue(low:25, high:100, prompt: "Type something");

- Methods default values

        static double readValue(double low, double hight, string prompt = ""){...}
        x = readValue(25, 100);

    the optional parameter must go after the required ones.
- In C# method I can force the use the reference to the input parameters

        static void addOneToRefParam(ref int i){...}

- There is also the "out" keyword. My understanding is that it will let the method to only assign values to this parameter. It will also force the programmer to assign the value inside the method

        int initializeInMethod;
        OutArgExample(out initializeInMethod);
        Console.WriteLine(initializeInMethod);     // value is now 44
        
        void OutArgExample(out int number)
        {
            number = 44;
        }

- In Visual Studio, every project accept Max one class with a Main method, otherwise it will not compile
- Multi dimension arrays are defined in this way:

        int[,,] twoDimension = new int[3, 3, 3];

### Chapter 04 Notes

- Struct are passed as values (copy) not like reference with the Objects
- Constructor chaining is a little bit different compared to how you do it in Java

        public CustomerAccount() : this("")
        { }

        public CustomerAccount(string name)
        {
            this.name = name;
            this.balance = 0;
        }

 - **Method Override**: I have to declare the "parent" method as "virtual", and the child as "override". The keyword virtual means “I might want to make another version of this method in a child class”. You don’t have to override the method, but if you don’t have the word present, you definitely can’t. This makes override and virtual a kind of matched pair. You use virtual to mark a method as able to be overridden and override to actually provide a replacement for the method.


         //Parent Class
         public virtual bool WithdrawFunds(decimal amount){...}
         //Child Class
         public override bool WithdrawFunds(decimal amount){...}

 - **Replace Method** There is an option to replace a method in the child class. This means that I don't have to make the parent method "virtual" 

          //Child Class
         public override bool WithdrawFunds(decimal amount){...}

 - C# **string** are immutable like in Java
 - **Delegates**, page 139, it is clear how it works, but the benefit is not clear to me...

### Chapter 05 Notes

- ArrayList works with **references** of type **object** (not typesafe)
- List<?> uses generics. Don't get confused from the Java, List is not an interface, it is the implementation
- Dictionary<?, ?>, I can use this instead of a Java HashMap<?, ?>. Carefull, when you try to retrieve the value, it will throw an exception if not available. It will not return null like in Java. You have first to check if it exists with the ".ContainsKey".
- Threads: the idea and concepts are the same as Java, but the way I start a new thread is a little bit different. In C# I have to tell to the Thread class which is the "starting method", I do this using "delegates" (now I understand when you can use a delegate, check the last note in chapert 04)
- Synchronise the code: In Java we have the **synchronise** keyword, in C# you have to use a specific class

        static object sync = new object();
        ...
        Monitor.Enter(sync); // Entering a sync block code
        ...
        Monitor.Exit(sync); // Leaving the sync block code

- **Exception**: The base class is System.Exception. No mention to checked and uncheked exceptions like in Java

