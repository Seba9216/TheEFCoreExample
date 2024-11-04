// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using nemt;

Console.WriteLine("Hello, World!");



using (nemtContext context = new())
{
    var alltasks = context.Tasks.Include(task => task.Todos);
    foreach (var task in alltasks)
    {
        Console.WriteLine(task.Name);
    }
    //UndoneTasks
    var alltasksNotDone = context.Tasks.Include(task => task.Todos).Where(x =>x.Todos.Any(x => x.IsDone == false));
    foreach(var task in alltasksNotDone) { Console.WriteLine(task.Name); }
}