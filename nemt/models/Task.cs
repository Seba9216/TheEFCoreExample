namespace nemt.models;
public class Task
{
    public int TaskId { get; set; }
    public string Name { get; set; }
    public List<Todo> Todos { get; set; }

    public Team team { get; set; }
    public int TeamId { get; set; }
}
