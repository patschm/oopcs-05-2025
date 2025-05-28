namespace Filteren;

class NameAndAge
{
    public int Age { get; set; }
    public string? Naam { get; set; }
}

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        people.Add(new Person {Id = 1, Name = "Gerrit", Age = 26 });
        people.Add(new Person {Id = 2, Name = "Aaron", Age = 46 });
        people.Add(new Person {Id=3, Name = "Sofie", Age = 16 });
        people.Add(new Person {Id = 4, Name = "Bea", Age = 6 });


       // string first = Console.ReadLine();

        //var col  = people.Where(FilterNameIsB);
        //var col = people.Where(delegate (Person p) { return p.Name.StartsWith(first); });

       // var col = people.Where(p => p.Name.StartsWith(first));

        bool b = people.Any(p => p.Age == 16);

        var xp = people.Select(p => new { Age = p.Age, Naam = p.Name});

        foreach (var person in xp)
        {
            Console.WriteLine($"{person.Naam} {person.Age}");
        }

        //List<Func<Dictionary<string, Action>, string>> iets = new List<Func<Dictionary<string, Action>, string>>();
        var iets = new List<Func<Dictionary<string, Action>, string>>();

        //iets = 1;
    }

    static bool FilterNameIsA(Person person)
    {
        return person.Name.StartsWith("A");
    }
    static bool FilterNameIsB(Person person)
    {
        return person.Name.StartsWith("B");
    }
}

class Person
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string? Name { get; set; }
}
