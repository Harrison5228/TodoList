namespace TodoApi.Models.Request;

public class TodoSearchRequest
{   
    public string? Title { get; set; }
    
    public string? Description { get; set; }
    
    public string? Username { get; set; }

    public bool? IsCompleted { get; set; }
    
    public DateTime? CreateDateTime { get; set; }
    
    public DateTime? UpdateDateTime { get; set; }
}