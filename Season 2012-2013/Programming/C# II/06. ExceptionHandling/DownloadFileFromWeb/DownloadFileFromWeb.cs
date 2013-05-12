using System;
using System.ComponentModel;
using System.Net;

class DownloadFileFromWeb
{
    static void Main()
    {
        try
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"C:\Users\PC03102012\Desktop\TestProgramDownload.jpg");
        }

        catch (WebException)
        {
            Console.Error.WriteLine("The address is invalid.");
        }

        catch (NotSupportedException)
        {
            Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
        }
    }
}

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//and stores it the current directory. Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block.
