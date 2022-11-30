using Microsoft.AspNetCore.Mvc;
using CarsApi.Models;

namespace CarsApi.Controllers;

[ApiController]
[Route("api/controller")]
public class CarsController : ControllerBase
{   
  
private readonly CarDetailsContext  DB;

public CarsController (CarDetailsContext db)
{   
    this.DB=db;

}
[HttpGet("GetCars")]

public Car CarDetailsContext (int carnum)
{
    try
    {
        return DB.Cars.Where(e=>e.Id.Equals(carnum)).FirstOrDefault();
    }
    catch (System.Exception)
    {
        
        throw;
    }
}


}