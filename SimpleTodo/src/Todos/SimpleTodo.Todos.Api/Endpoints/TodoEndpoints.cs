using SimpleTodo.Todos.Api.Models.Requests;

namespace SimpleTodo.Todos.Api.Endpoints;

public static class TodoEndpoints
{
    public static void MapTodosEndpoints(this IEndpointRouteBuilder app) 
    {
        app.MapPost("todo", async (CreateTodoRequest request) =>
        {
            return Task.FromResult(10);
        });
    }
}
