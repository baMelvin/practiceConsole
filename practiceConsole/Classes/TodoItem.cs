using System.Text.Json.Serialization;

public class TodoItem
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("completed")]
    public bool Completed { get; set; }

    public override string ToString()
    {
        
        return $"TodoItem: ID={Id}, Title={Title}, Completed={Completed}";
    }
}
