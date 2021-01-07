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
    [HttpGet("{id}", Name="GetFactureById")]
    public ActionResult<FactureToReturnDto> GetFactureById(int id)
    {
      var facture = _repository.GetFactureById(id);

      return Ok(facture);
    }

    //POST api/fakture
    [HttpPost]
    public ActionResult<Fakture> CreateFacture(Fakture facture)
    {
        _repository.CreateFacture(facture);

        return Ok(facture);
    }

        
    [HttpPut]
    public ActionResult<Fakture> UpdateFacture(Fakture facture)
    {
        _repository.UpdateFacture(facture);

        return Ok(facture);
    }

    //DELETE api/fakture/{id}
    [HttpDelete("{id}")]
    public ActionResult<Fakture> DeleteCommand(int id)
    {
        _repository.DeleteFactureById(id);

        return NoContent();
    }
  }
}