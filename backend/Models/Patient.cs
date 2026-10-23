namespace RetinaApi.Models;

public class Patient
{
    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; } = "";
    public string DiabetesType { get; set; } = "";
    public int? DiabetesYears { get; set; }
    public double? HbA1c { get; set; }
    public int? DoctorId { get; set; }
    public Doctor? Doctor { get; set; }
}
