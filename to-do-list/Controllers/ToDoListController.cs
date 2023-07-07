using Microsoft.AspNetCore.Mvc;
using to_do_list.models;
using to_do_list.services;

namespace to_do_list.Controllers;

[ApiController]
[Route("to-do")]
public class ToDoListController : ControllerBase
{
    private readonly ILogger<ToDoListController> _logger;
    private readonly ToDoListService service;

    public ToDoListController(ILogger<ToDoListController> logger, ToDoListService service)
    {
        this._logger = logger;
        this.service = service;
    }

    [HttpPost]
    public async Task<IActionResult> AddNew([FromBody] List<ToDoDTO> body)
    {
        foreach (var item in body)
        {
            this.service.AddPendingTask(item.Name);
        }

        return this.Created("", null);
    }

    [HttpPut]
    public async Task<IActionResult> Check([FromBody] List<ToDoDTO> body) 
    {
        foreach (var item in body)
        {
            this.service.FinishTask(item.Name);
        }

        return this.Ok();
    }

    [HttpGet]
    public async Task<IEnumerable<ToDo>> Get()
    {
        return this.service.Get();
    }
}

