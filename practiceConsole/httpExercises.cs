using System.Text.Json;

public class HttpExercises()
{
    async Task<TodoItem> getPlaceholder(string url)
    {
        using var client = new HttpClient();

        var res = await client.GetStringAsync(url);

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var todo = JsonSerializer.Deserialize<TodoItem>(res, options) ?? new TodoItem(){ Title = "null"};

        return todo;
    }

}