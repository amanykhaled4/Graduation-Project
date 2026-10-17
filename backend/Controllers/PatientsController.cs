using Microsoft.AspNetCore.Mvc;
using RetinaApi.Models;

namespace RetinaApi.Controllers;

[ApiController]
[Route("api/patients")]
public class PatientsController : ControllerBase
{
    private static List<Patient> patients = new()
    {
        new Patient { Id = 1, FullName = "Hoda Samir", Age = 47, Gender = "Female", DiabetesType = "Type 2" },
        new Patient { Id = 2, FullName = "Mahmoud Adel", Age = 58, Gender = "Male", DiabetesType = "Type 2" },
        new Patient { Id = 3, FullName = "Youssef Nabil", Age = 34, Gender = "Male", DiabetesType = "Type 1" }
    };

    [HttpGet]
    public List<Patient> GetAll()
    {
        return patients;
    }
        [HttpGet("{id}")]
    public ActionResult<Patient> GetOne(int id)
    {
        var patient = patients.FirstOrDefault(p => p.Id == id);

        if (patient == null)
            return NotFound();

        return patient;
    }

}
