public class UserSessionService
{
    public string UserId { get; set; }
    public string Username { get; set; }
    public DateTime LastActive { get; set; } = DateTime.UtcNow;

    public void StartSession(string userId, string username)
    {
        UserId = userId;
        Username = username;
        LastActive = DateTime.UtcNow;
    }

    public void UpdateActivity()
    {
        LastActive = DateTime.UtcNow;
    }

    public void EndSession()
    {
        UserId = null;
        Username = null;
    }

    public bool IsSessionActive => !string.IsNullOrWhiteSpace(UserId);
}