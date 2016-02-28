using System;

public class Human
{
    public Sex Sex { get; set; }

    public string PersonName { get; set; }

    public int Age { get; set; }

    public void CreateHuman(int age)
    {
        Human human = new Human();
        human.Age = age;

        if (age % 2 == 0)
        {
            human.PersonName = "Pesho";
            human.Sex = Sex.Male;
        }
        else
        {
            human.PersonName = "Mariika";
            human.Sex = Sex.Female;
        }
    }
}