using System.Globalization;
using System.Threading.Channels;

namespace Struct;

public struct Person
{
    private int _age;
    private int _height;
    private Gender _gender;

    public string? Name { get; set; } = null!;

    public int Age
    {
        get { return _age; }
        set
        {
            if (value <= 100)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("value cannot be changed");
            }
        }
    }

    public Person()
    {
        _age = 10;
        _height = 170;
        _gender = Gender.Female;
    }

    public Person(string name, int age, int height, Gender gender)
    {
        _age = age;
        _height = height;
        _gender = gender;
        Name = name;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"name: {Name}\nage:{_age}\nheight:{_height}\ngender:{_gender}");
    }

    public int IncreaseAge(int limit)
    {
        _age += limit;

        return _age;    
    }
}