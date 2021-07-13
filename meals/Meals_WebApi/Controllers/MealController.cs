using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Meals_WebApi.Data;

namespace Meals_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MealController : ControllerBase
    {
    
    #region [Properties]
    private readonly IRepository _repository;
    #endregion

    #region [Constructor]
    public MealController(IRepository repository)
    {
        _repository = repository;
    }
    #endregion

    #region [Methods]
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var result = await _repository.GetAllMealsAsync();
            return Ok(result);
        }
        catch(Exception ex)
        {
            return BadRequest($"Erro: {ex.Message}");
        }        
    }

    [HttpGet("byMealName/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        try
        {
            var result = await _repository.GetMealAsyncByName(name);
            return Ok(result);
        }
        catch(Exception ex)
        {
            return BadRequest($"Erro: {ex.Message}");
        }        
    }
    #endregion
    }
}