using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Pesho");
        Person person2 = new Person("Mariika", 22);

        Console.WriteLine(person);
        Console.WriteLine(person2);
    }
}

//Create a class Person with two fields – name and age.
//    Age can be left unspecified (may contain null value. Override ToString()
//        to display the information of a person and if age is not specified – to say so. 
//            Write a program to test this functionality.