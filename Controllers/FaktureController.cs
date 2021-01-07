using System;
using System.Collections.Generic;
using Data;
using Dtos;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
  [Route("api/fakture")]
  [ApiController]
  public class FaktureController : ControllerBase
  {
    private readonly IFakturaRepo _repository;

    public FaktureController(IFakturaRepo repository)
    {
      _repository = repository;
    }

    //GET api/fakture
    [HttpGet]
    public ActionResult<IEnumerable<FactureToReturnDto>> GetAllFacture()
    {
      var factures = _repository.GetFactures();


      return Ok(factures);
    }

    //GET api/fakture/{id}
    [HttpGet("{id}")]
    public ActionResult<FactureToReturnDto> GetFactureById(int id)
    {
      var facture = _repository.GetFactureById(id);

      return Ok(facture);
    }

  }
}