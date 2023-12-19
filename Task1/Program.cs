string a = Console.ReadLine();
string b = Console.ReadLine();
int c = Convert.ToInt32(Console.ReadLine());

var person = new Person();
person.FirstName = a;
person.LastName = b;
person.Age = c;


System.Console.WriteLine(person.GetInfo());
System.Console.WriteLine(person.GetInfo2());
System.Console.WriteLine(person.GetInfo3());


class Person
{
    public string FirstName;
    public string GetInfo()
    {
        return $"FirstName: {FirstName}";
    }
    public string LastName;
    public string GetInfo2()
    {
        return $"LastName: {LastName}";
    }
    public int Age;
    public string GetInfo3()
    {
        return $"Age: {Age}";
    }
}
