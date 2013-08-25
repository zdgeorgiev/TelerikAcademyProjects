using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Human
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int JobRating { get; set; }

    public Human(string name, string lastName)
    {
        this.Name = name;
        this.LastName = lastName;
    }
}

class Employees
{
    static void Main(string[] args)
    {
        Dictionary<string, int> jobs = new Dictionary<string, int>();

        int numberOfJobs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfJobs; i++)
        {
            string[] currentJob = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            if (!jobs.ContainsKey(currentJob[0].Trim()))
            {
                jobs.Add(currentJob[0].Trim(), int.Parse(currentJob[1]));
            }
        }

        List<Human> allHumans = new List<Human>();

        int numberOfHumans = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfHumans; i++)
        {
            string[] currentJob = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            string[] names = currentJob[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            allHumans.Add(new Human(names[0], names[1]));
            allHumans[i].JobRating = jobs[currentJob[1].Trim()];
        }

        var sortedJobsByRating = allHumans.OrderByDescending(h => h.JobRating).GroupBy(h => h.JobRating).ToList();
        StringBuilder result = new StringBuilder();

        int c = 0;

        foreach (var human in sortedJobsByRating)
        {
            foreach (var name in sortedJobsByRating[c].OrderBy(h => h.LastName).ThenBy(h => h.Name))
            {
                result.AppendLine(name.Name + " " + name.LastName);
            }

            c++;
        }

        Console.WriteLine(result.ToString());
    }
}