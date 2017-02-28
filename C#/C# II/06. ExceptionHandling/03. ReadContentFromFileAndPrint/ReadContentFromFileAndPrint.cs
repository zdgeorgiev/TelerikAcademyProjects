using System;
using System.IO;
using System.Security;

class ReadContentFromFileAndPrint
{
    static void Main(string[] args)
    {
        //File in the current directory as the csharpFile
        string path = @"..\..\text.txt";

        try
        {
            string textFromFile = File.ReadAllText(path);
            Console.WriteLine(textFromFile);

        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Path you entered is null.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine(
                "Path you entered lenght is zero or contains one or more InvalidPathChars.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine(
                "The specified path, file name, or both exceed the system-defined maximum length.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory from this path is invalid.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine(
                "The caller does not have the required permission or path specified a file that is read-only.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Directory path is not found.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("{ath is in an invalid format.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
    }
}

//Write a program that enters file name along with its full file
//path (e.g. C:\WINDOWS\win.ini), reads its contents and prints
//it on the console. Find in MSDN how to use
//System.IO.File.ReadAllText(…). Be sure to catch all
//possible exceptions and print user-friendly error messages.