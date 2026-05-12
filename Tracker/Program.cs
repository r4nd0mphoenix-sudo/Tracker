
class Habit
{
    public string Name { get; set; }
    public int Streak {get; set;}
    public string Date { get; set;}
    public string Comment { get; set;}

}

class  Output
{ 
    static public void habitOutput(Habit habit)
    {
        Console.WriteLine($"{habit.Name} {habit.Streak}");
        int i = habit.Streak;
        while (i>0)
        {
            Console.Write("*");
            i--;
        }
    }

    static public void habitInfo(Habit habit)
    {
        if (habit.Comment != null) Console.WriteLine($"{habit.Comment}");
        Console.WriteLine($"{habit.Name} {habit.Streak} {habit.Date}");
    }
}

class Interface
{
    static public void Menu()
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
        Habit habit = new Habit();
        habit.Name = "test";
        habit.Streak = 8;
        Output.habitOutput(habit);
    }
}