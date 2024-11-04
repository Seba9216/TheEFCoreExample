namespace nemt.models;

public class Worker
{
    public int WorkerId { get; set; }
    public string WorkerName { get; set; }
    public List<TeamWorker> Teams { get; set; }
    public List<Todo> TodoList { get; set; }

    public Todo CurrentToDo { get; set; }
    
}
