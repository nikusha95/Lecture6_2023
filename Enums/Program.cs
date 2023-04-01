// See https://aka.ms/new-console-template for more information

using Enums;

int x;

x = 10;

PersonType type1;

type1 = (PersonType)100; //Teacher

Console.WriteLine(type1);


string type = Console.ReadLine();
PersonType typeEnum = Enum.Parse<PersonType>(type);

Console.WriteLine(typeEnum);

Console.WriteLine(PersonType.Teacher);
Console.WriteLine((int)PersonType.Teacher);