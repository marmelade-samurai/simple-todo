using Microsoft.AspNetCore.Mvc;
using SimpleTodo.Todos.Api.Models.Requests;
using SimpleTodo.Todos.Api.Models.Responses;

namespace SimpleTodo.Todos.Api.Endpoints;

public static class TodoEndpoints
{
    public static void MapTodosEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("todos", async ([FromBody] CreateTodoRequest request) =>
        {
            CreateTodoResponse response = new(Random.Shared.NextInt64());

            await Task.Delay(100);

            Results.Ok(response);
        }).WithSummary("Create todo item in list.")
          .WithOpenApi();           
    }
}
