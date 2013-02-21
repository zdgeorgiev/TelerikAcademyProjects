using System;
using System.IO;
using System.Security;

namespace ReadAndPrint
{

    class ReadAndPrintFileContent
    {
        static void PrintFileContent(string pathFile)
        {
            string contentFile = System.IO.File.ReadAllText(pathFile);
            Console.WriteLine(contentFile);
        }

        static void Main()
        {
            Console.WriteLine("Please, enter the full path to the file:");
            try
            {
                string pathFile = Console.ReadLine();
                PrintFileContent(pathFile);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The given path is NULL\n and some method received a null argument!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine(" The specified path, file name, or both exceed\n the system-defined maximum length." +
                    "Path must be\n less than 248 characters, and file names\n must be less than 260 characters.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The given path is in an invalid format.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccesException detected! The reasons may be the following:\n" +
                    " - Path specified a file that is read-only.\n - This operation is not supported on the current platform.\n" +
                    " - The caller does not have the required permission.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Sorry, but you does not have the required permission.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O (Input/Output) error occurred while opening the file.");
            }
        }
    }
}