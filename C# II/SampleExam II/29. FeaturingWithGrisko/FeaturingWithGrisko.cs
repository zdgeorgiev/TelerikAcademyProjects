using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Cons123123
{
    class Program
    {
        static Dictionary<string, int> allLetterFromStr = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                if (!allLetterFromStr.ContainsKey(words[i].ToString()))
                {
                    allLetterFromStr.Add(words[i].ToString(), Count(words, words[i].ToString()));
                }
            }

            List<string> combinations = new List<string>();

            if (words.Length == 1)
            {
                Console.WriteLine(1);
                Environment.Exit(0);
            }
            else if (words.Length == 2)
            {
                for (int a = 0; a < words.Length; a++)
                {
                    for (int b = 0; b < words.Length; b++)
                    {
                        if (!(a == b))
                            combinations.Add(words[a].ToString() + words[b].ToString());
                    }
                }
            }
            #region 3
            else if (words.Length == 3)
            {
                for (int a = 0; a < words.Length; a++)
                {
                    for (int b = 0; b < words.Length; b++)
                    {
                        for (int c = 0; c < words.Length; c++)
                        {
                            if (!(a == b || a == c || b == c) && !combinations.Contains(words[a].ToString() + words[b].ToString() + words[c].ToString()))
                                combinations.Add(words[a].ToString() + words[b].ToString() + words[c].ToString());
                        }
                    }
                }
            }
            #endregion
            #region 4
            else if (words.Length == 4)
            {
                for (int a = 0; a < words.Length; a++)
                {
                    for (int b = 0; b < words.Length; b++)
                    {
                        for (int c = 0; c < words.Length; c++)
                        {
                            for (int d = 0; d < words.Length; d++)
                            {
                                if (!(a == b || a == c || b == c || a == d || d == b || d == c)
                                    && !combinations.Contains(words[a].ToString() + words[b].ToString() + words[c].ToString() + words[d].ToString()))
                                    combinations.Add(words[a].ToString() + words[b].ToString() + words[c].ToString() + words[d].ToString());
                            }
                        }
                    }
                }
            }
            #endregion
            #region 5
            else if (words.Length == 5)
            {
                for (int a = 0; a < words.Length; a++)
                {
                    for (int b = 0; b < words.Length; b++)
                    {
                        for (int c = 0; c < words.Length; c++)
                        {
                            for (int d = 0; d < words.Length; d++)
                            {
                                for (int f = 0; f < words.Length; f++)
                                {
                                    if (!(a == b || a == c || b == c || a == d || d == b || d == c || a == f || b == f || c == f || d == f) &&
                                        !combinations.Contains(words[a].ToString()
                                            + words[b].ToString()
                                            + words[c].ToString()
                                            + words[d].ToString()
                                            + words[f].ToString()))
                                        combinations.Add(words[a].ToString()
                                            + words[b].ToString()
                                            + words[c].ToString()
                                            + words[d].ToString()
                                            + words[f].ToString());
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            #region 6
            else if (words.Length == 6)
            {
                for (int a = 0; a < words.Length; a++)
                {
                    for (int b = 0; b < words.Length; b++)
                    {
                        for (int c = 0; c < words.Length; c++)
                        {
                            for (int d = 0; d < words.Length; d++)
                            {
                                for (int f = 0; f < words.Length; f++)
                                {
                                    for (int g = 0; g < words.Length; g++)
                                    {
                                        if (!(a == b ||
                                            a == c ||
                                            b == c ||
                                            a == d ||
                                            d == b ||
                                            d == c ||
                                            a == f ||
                                            b == f ||
                                            c == f ||
                                            d == f ||
                                            a == g ||
                                            b == g ||
                                            d == g ||
                                            f == g) &&
                                            !combinations.Contains(words[a].ToString()
                                                + words[b].ToString()
                                                + words[c].ToString()
                                                + words[d].ToString()
                                                + words[f].ToString()
                                                + words[g].ToString()))

                                            combinations.Add(words[a].ToString()
                                                + words[b].ToString()
                                                + words[c].ToString()
                                                + words[d].ToString()
                                                + words[f].ToString()
                                                + words[g].ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            #region 7
            else if (words.Length == 7)
            {
                for (int a = 0; a < words.Length; a++)
                {
                    for (int b = 0; b < words.Length; b++)
                    {
                        for (int c = 0; c < words.Length; c++)
                        {
                            for (int d = 0; d < words.Length; d++)
                            {
                                for (int f = 0; f < words.Length; f++)
                                {
                                    for (int g = 0; g < words.Length; g++)
                                    {
                                        for (int h = 0; h < words.Length; h++)
                                        {
                                            if (!(a == b ||
                                                a == c ||
                                                b == c ||
                                                a == d ||
                                                d == b ||
                                                d == c ||
                                                a == f ||
                                                b == f ||
                                                c == f ||
                                                d == f ||
                                                a == g ||
                                                b == g ||
                                                d == g ||
                                                f == g ||
                                                a == h ||
                                                b == h ||
                                                c == h ||
                                                d == h ||
                                                f == h ||
                                                d == h
                                                && !combinations.Contains(words[a].ToString()
                                                    + words[b].ToString()
                                                    + words[c].ToString()
                                                    + words[d].ToString()
                                                    + words[f].ToString()
                                                    + words[g].ToString()
                                                    + words[h].ToString())))

                                                combinations.Add(words[a].ToString()
                                                    + words[b].ToString()
                                                    + words[c].ToString()
                                                    + words[d].ToString()
                                                    + words[f].ToString()
                                                    + words[g].ToString()
                                                    + words[h].ToString());
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            #region 8
            else if (words.Length == 8)
            {
                for (int a = 0; a < words.Length; a++)
                {
                    for (int b = 0; b < words.Length; b++)
                    {
                        for (int c = 0; c < words.Length; c++)
                        {
                            for (int d = 0; d < words.Length; d++)
                            {
                                for (int f = 0; f < words.Length; f++)
                                {
                                    for (int g = 0; g < words.Length; g++)
                                    {
                                        for (int h = 0; h < words.Length; h++)
                                        {
                                            for (int j = 0; j < words.Length; j++)
                                            {
                                                if (!(a == b ||
                                                    a == c ||
                                                    b == c ||
                                                    a == d ||
                                                    d == b ||
                                                    d == c ||
                                                    a == f ||
                                                    b == f ||
                                                    c == f ||
                                                    d == f ||
                                                    a == g ||
                                                    b == g ||
                                                    d == g ||
                                                    f == g ||
                                                    a == h ||
                                                    b == h ||
                                                    c == h ||
                                                    d == h ||
                                                    f == h ||
                                                    d == h ||
                                                    a == j ||
                                                    b == j ||
                                                    c == j ||
                                                    d == j ||
                                                    f == j ||
                                                    g == j ||
                                                    h == j) &&
                                                    !combinations.Contains(words[a].ToString()
                                                        + words[b].ToString()
                                                        + words[c].ToString()
                                                        + words[d].ToString()
                                                        + words[f].ToString()
                                                        + words[g].ToString()
                                                        + words[h].ToString()
                                                        + words[j].ToString()))

                                                    combinations.Add(words[a].ToString()
                                                        + words[b].ToString()
                                                        + words[c].ToString()
                                                        + words[d].ToString()
                                                        + words[f].ToString()
                                                        + words[g].ToString()
                                                        + words[h].ToString()
                                                        + words[j].ToString());
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            #region 9
            else if (words.Length == 9)
            {
                for (int a = 0; a < words.Length; a++)
                {
                    for (int b = 0; b < words.Length; b++)
                    {
                        for (int c = 0; c < words.Length; c++)
                        {
                            for (int d = 0; d < words.Length; d++)
                            {
                                for (int f = 0; f < words.Length; f++)
                                {
                                    for (int g = 0; g < words.Length; g++)
                                    {
                                        for (int h = 0; h < words.Length; h++)
                                        {
                                            for (int j = 0; j < words.Length; j++)
                                            {
                                                for (int k = 0; k < words.Length; k++)
                                                {
                                                    if (!(a == b ||
                                                        a == c ||
                                                        b == c ||
                                                        a == d ||
                                                        d == b ||
                                                        d == c ||
                                                        a == f ||
                                                        b == f ||
                                                        c == f ||
                                                        d == f ||
                                                        a == g ||
                                                        b == g ||
                                                        d == g ||
                                                        f == g ||
                                                        a == h ||
                                                        b == h ||
                                                        c == h ||
                                                        d == h ||
                                                        f == h ||
                                                        d == h ||
                                                        a == j ||
                                                        b == j ||
                                                        c == j ||
                                                        d == j ||
                                                        f == j ||
                                                        g == j ||
                                                        h == j ||
                                                        a == k ||
                                                        b == k ||
                                                        c == k ||
                                                        d == k ||
                                                        f == k ||
                                                        g == k ||
                                                        h == k ||
                                                        j == k) &&
                                                        !combinations.Contains(words[a].ToString()
                                                            + words[b].ToString()
                                                            + words[c].ToString()
                                                            + words[d].ToString()
                                                            + words[f].ToString()
                                                            + words[g].ToString()
                                                            + words[h].ToString()
                                                            + words[j].ToString()
                                                            + words[k].ToString()))

                                                        combinations.Add(words[a].ToString()
                                                            + words[b].ToString()
                                                            + words[c].ToString()
                                                            + words[d].ToString()
                                                            + words[f].ToString()
                                                            + words[g].ToString()
                                                            + words[h].ToString()
                                                            + words[j].ToString()
                                                            + words[k].ToString());
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            #region 10
            else if (words.Length == 10)
            {
                for (int a = 0; a < words.Length; a++)
                {
                    for (int b = 0; b < words.Length; b++)
                    {
                        for (int c = 0; c < words.Length; c++)
                        {
                            for (int d = 0; d < words.Length; d++)
                            {
                                for (int f = 0; f < words.Length; f++)
                                {
                                    for (int g = 0; g < words.Length; g++)
                                    {
                                        for (int h = 0; h < words.Length; h++)
                                        {
                                            for (int j = 0; j < words.Length; j++)
                                            {
                                                for (int k = 0; k < words.Length; k++)
                                                {
                                                    for (int l = 0; l < words.Length; l++)
                                                    {
                                                        if (!(a == b ||
                                                            a == c ||
                                                            b == c ||
                                                            a == d ||
                                                            d == b ||
                                                            d == c ||
                                                            a == f ||
                                                            b == f ||
                                                            c == f ||
                                                            d == f ||
                                                            a == g ||
                                                            b == g ||
                                                            d == g ||
                                                            f == g ||
                                                            a == h ||
                                                            b == h ||
                                                            c == h ||
                                                            d == h ||
                                                            f == h ||
                                                            d == h ||
                                                            a == j ||
                                                            b == j ||
                                                            c == j ||
                                                            d == j ||
                                                            f == j ||
                                                            g == j ||
                                                            h == j ||
                                                            a == k ||
                                                            b == k ||
                                                            c == k ||
                                                            d == k ||
                                                            f == k ||
                                                            g == k ||
                                                            h == k ||
                                                            j == k ||
                                                            a == l ||
                                                            b == l ||
                                                            c == l ||
                                                            d == l ||
                                                            f == l ||
                                                            g == l ||
                                                            h == l ||
                                                            j == l ||
                                                            k == l) &&
                                                            !combinations.Contains(words[a].ToString()
                                                                + words[b].ToString()
                                                                + words[c].ToString()
                                                                + words[d].ToString()
                                                                + words[f].ToString()
                                                                + words[g].ToString()
                                                                + words[h].ToString()
                                                                + words[j].ToString()
                                                                + words[k].ToString()
                                                                + words[l].ToString()))

                                                            combinations.Add(words[a].ToString()
                                                                + words[b].ToString()
                                                                + words[c].ToString()
                                                                + words[d].ToString()
                                                                + words[f].ToString()
                                                                + words[g].ToString()
                                                                + words[h].ToString()
                                                                + words[j].ToString()
                                                                + words[k].ToString()
                                                                + words[l].ToString());
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            int count = 0;

            foreach (var item in combinations.Distinct())
            {
                if (IsValid(item))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        private static bool IsValid(string item)
        {
            bool isvalud = true;

            for (int i = 0; i < item.Length - 1; i++)
            {
                if (Count(item, item[i].ToString()) != allLetterFromStr[item[i].ToString()])
                {
                    return false;
                }

                if (item[i] == item[i + 1])
                {
                    return false;
                }
            }

            return isvalud;
        }

        private static int Count(string str, string charr)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == charr)
                {
                    count++;
                }
            }

            return count;
        }
    }
}