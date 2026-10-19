namespace RetinaApi.Models;

public class Doctor
{
    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public string Specialty { get; set; } = "";
}
