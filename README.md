# Learning C#

I am a Java certified developer, hence I mainly worked with Java. 
As a developer I like to continue to learn new things, it is time for me to learn 
the C# (C Sharp, not C Hash) language.
So... I am reading [this](http://www.csharpcourse.com/) book, and I will put in this repo all the exercises that 
I will do.

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

- There is also the "out" keyword. My understanding is that it will let the method to only assign values to this 
 parameter. It will also force the programmer to assign the value inside the method

        int initializeInMethod;
        OutArgExample(out initializeInMethod);
        Console.WriteLine(initializeInMethod);     // value is now 44
        
        void OutArgExample(out int number)
        {
            number = 44;
        }
