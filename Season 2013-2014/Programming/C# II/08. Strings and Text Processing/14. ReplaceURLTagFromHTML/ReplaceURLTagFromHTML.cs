using System;

class ReplaceURLTagFromHTML
{
    public const string OpenTag = "<a href";
    public const string EndOfTheWebSite = ">";
    public const string CloseTag = "</a>";

    static void Main(string[] args)
    {
        string html = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        int indexOfOpenTag = -1;
        indexOfOpenTag = html.IndexOf(OpenTag, indexOfOpenTag + 1);

        while (indexOfOpenTag != -1)
        {
            html = html.Replace(html.Substring(indexOfOpenTag, OpenTag.Length + 2), "[URL=");

            int indexOfEndOfTheWebSite = html.IndexOf(EndOfTheWebSite, indexOfOpenTag);
            html = html.Replace(html.Substring(indexOfEndOfTheWebSite - 1, 2), "]");

            int indexOfCloseTag = html.IndexOf(CloseTag, indexOfEndOfTheWebSite);
            html = html.Replace(html.Substring(indexOfCloseTag, CloseTag.Length), "[/URL]");

            indexOfOpenTag = html.IndexOf(OpenTag, indexOfOpenTag + 1);
        }

        Console.WriteLine(html);
    }
}

//Write a program that replaces in a HTML document given as
//string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].