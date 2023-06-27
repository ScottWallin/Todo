namespace Todo.Controllers;
[ApiController]
[Route("api/todos")]
public class TodosController : ControllerBase
{
  private readonly TodosService _todosService;
  public TodosController(TodosService todosService)
  {
    _todosService = todosService;
  }
  [HttpGet]
  public ActionResult<List<ToDo>> GetAllTodos()
  {
    try
    {
      List<ToDo> todos = _todosService.GetAllTodos();
      return Ok(todos);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}