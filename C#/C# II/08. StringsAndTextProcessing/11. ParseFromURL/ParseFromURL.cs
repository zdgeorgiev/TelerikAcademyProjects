using System;

class ParseFromURL
{
    static void Main(string[] args)
    {
        string url = "http://www.devbg.org/forum/index.php";

        int indexOfDoubleDot = url.IndexOf(":");
        int indexOfTrippleW = url.IndexOf("www");
        int indexOfRightLine = url.IndexOf("/", indexOfTrippleW);

        string protocol = url.Substring(0, indexOfDoubleDot);
        string server = url.Substring(indexOfTrippleW, indexOfRightLine - indexOfTrippleW);
        string resource = url.Substring(indexOfRightLine, url.Length - indexOfRightLine);

        Console.WriteLine(protocol + "://" + server + resource);
    }
}

//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements.
//For example from the URL http://www.devbg.org/forum/index.php
//the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"