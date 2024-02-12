namespace ChatApp.Web.Models;
public class Message
{
  public int Id { get; set; }
  public string Content { get; set; } = "";
  public DateTime CreatedAt { get; set; }
}

