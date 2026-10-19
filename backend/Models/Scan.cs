namespace RetinaApi.Models;

public class Scan
{
    public int Id { get; set; }

    public int PatientId { get; set; }
    public Patient? Patient { get; set; }

    public int? DoctorId { get; set; }
    public Doctor? Doctor { get; set; }

    public string Eye { get; set; } = "Right";
    public string ImagePath { get; set; } = "";
    public string? HeatmapPath { get; set; }
    public int Grade { get; set; }
    public double Confidence { get; set; }
    public string Status { get; set; } = "Pending";
    public string? DoctorNote { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
