using Microsoft.AspNetCore.Mvc;
using RetinaApi.Data;
using RetinaApi.Models;

namespace RetinaApi.Controllers;

[ApiController]
[Route("api/patients")]
public class PatientsController : ControllerBase
{
    private readonly AppDbContext _db;

    public PatientsController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public List<Patient> GetAll()
    {
        return _db.Patients.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Patient> GetOne(int id)
    {
        var patient = _db.Patients.Find(id);
        if (patient == null)
            return NotFound();

        return patient;
    }

    [HttpPost]
    public ActionResult<Patient> Create(Patient patient)
    {
        patient.Id = 0;
        _db.Patients.Add(patient);
        _db.SaveChanges();
        return patient;
    }

    [HttpPut("{id}")]
    public ActionResult<Patient> Update(int id, Patient updated)
    {
        var patient = _db.Patients.Find(id);
        if (patient == null)
            return NotFound();

        patient.FullName = updated.FullName;
        patient.Age = updated.Age;
        patient.Gender = updated.Gender;
        patient.DiabetesType = updated.DiabetesType;
        _db.SaveChanges();
        return patient;
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var patient = _db.Patients.Find(id);
        if (patient == null)
            return NotFound();

        _db.Patients.Remove(patient);
        _db.SaveChanges();
        return NoContent();
    }
}
