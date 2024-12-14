using Microsoft.AspNetCore.Mvc;
using SimpleTodo.Todos.Api.Models.Requests;

namespace SimpleTodo.Todos.Api.Endpoints;

public static class TodoEndpoints
{
    public static void MapTodosEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("todos", async ([FromBody] CreateTodoRequest request) =>
        {
            return Task.FromResult(10);
        });
    }
}
