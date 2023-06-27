namespace Todo.Repositories;
public class TodosRepository
{
  private List<ToDo> dbTodos;
  public TodosRepository()
  {
    this.dbTodos = new List<ToDo> { };
    dbTodos.Add(new ToDo(1, "Laundry", 60, "Congrats, you don't stink anymore", true));
    dbTodos.Add(new ToDo(2, "Dishes", 10, "You can eat off clean plates now. Huzzah.", true));
    dbTodos.Add(new ToDo(3, "Dog Poop", 20, "Clean up, peasant", false));
  }
  internal List<ToDo> GetAllTodos()
  {
    return dbTodos;
  }
  internal ToDo GetById(int todoId)
  {
    ToDo todo = dbTodos.Find(t => t.Id == todoId);
    return todo;
  }
}