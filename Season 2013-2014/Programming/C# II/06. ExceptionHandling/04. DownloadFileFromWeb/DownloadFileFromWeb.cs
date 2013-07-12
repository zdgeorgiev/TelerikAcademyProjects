using System;
using System.Net;

class DownloadFileFromWeb
{
    static void Main(string[] args)
    {
        WebClient webClient = new WebClient();

        try
        {
            Console.WriteLine("Downloading file...");
            webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"..\..\Picture.jpg");

            if (!webClient.IsBusy)
            {
                Console.WriteLine("Finished.");
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Adress parameter is null.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
        catch (WebException)
        {
            Console.WriteLine("The URI formed by combining BaseAddress and address is invalid.");
            Console.WriteLine("or filename is null or Empty. \nor The file does not exist. \nor An error occurred while downloading data");
        }
    }
}

//Write a program that downloads a file from Internet
//(e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//and stores it the current directory. Find in
//Google how to download files in C#. Be sure to
//catch all exceptions and to free any used resources in the finally block.