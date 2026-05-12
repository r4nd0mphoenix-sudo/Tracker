
class Habbit
{
    public string Name { get; set; }
    public int Streak {get; set;}
    public string Date { get; set;}
    public string Comment { get; set;}

}

class  Output
{ 
    static public void HabbitOutput(Habbit habbit)
    {
        Console.WriteLine($"{habbit.Name} {habbit.Streak}");
        int i = habbit.Streak;
        while (i>0)
        {
            Console.Write("*");
            i--;
        }
    }

    static public void HabbitInfo(Habbit habbit)
    {
        if (habbit.Comment != null) Console.WriteLine($"{habbit.Comment}");
        Console.WriteLine($"{habbit.Name} {habbit.Streak} {habbit.Date}");
    }
}

class Interface
{
    static public void Menue()
    {
        Console.WriteLine("Как успехи и с чего начнем?");
        Console.WriteLine("Что успел сделать за сегодня?"); //после этой строчки должен выводиться список задач и должна быть возможность отметить привычки которые соблюдаюся
        Console.WriteLine();
    }

}

class program
{
    static void Main()
    {
        Habbit habbit = new Habbit();
        habbit.Name = "test";
        habbit.Streak = 8;
        Output.HabbitOutput(habbit);
    }
}