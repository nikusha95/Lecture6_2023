using Struct;

//
// int res = Sum(1, 2);
//
// Console.WriteLine(res);
// SumPrint(2,2);

Person p = new Person();

Console.WriteLine(p.Age);

p.Age = 110;

p.Name = "Naomi";

p.PrintInfo();
Console.WriteLine();

Person p2 = new Person("Nini", 20, 160, Gender.Female);

p2.PrintInfo();
p2.IncreaseAge(20);
Console.WriteLine();
p2.PrintInfo();


Tuple<int, string> someth = GetPersonInfo("John", "Doe", 50);
(int, string) tuple = someth.ToValueTuple();
Console.WriteLine(someth.Item1);
Console.WriteLine(someth.Item2);


Tuple<int, string> GetPersonInfo(string name, string lastName, int age) //(int,string)
{
    return new Tuple<int, string>(age, $"{name} {lastName}");
}


int Sum(int a, int b)
{
    return a + b;
}

void SumPrint(int a, int b)
{
    Console.WriteLine(a + b);
}