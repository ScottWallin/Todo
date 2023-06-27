namespace Todo.Services;
public class TodosService
{
  private readonly TodosRepository _repo;
  public TodosService(TodosRepository repo)
  {
    _repo = repo;
  }
  public List<ToDo> GetAllTodos()
  {
    List<ToDo> todos = _repo.GetAllTodos();
    return todos;
  }
}