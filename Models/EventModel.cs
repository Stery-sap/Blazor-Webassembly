using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
   public class EventModel
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }

    public List<string> Attendees { get; set; } = new();
}
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}