using DomainModel;
namespace WebMvc.Service;

public interface ITaskService
{
    public List<MyTask> GetAllTasks();
    public MyTask? FindTaskByID(int id);
    public void UpdateTaskByID(int id, string title, string content, DateTime dueDate);
    public int getNextId();
    public void createTask(int id, string title, string content, DateTime dueDate);
}