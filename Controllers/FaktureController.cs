using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
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
    private readonly IMapper _mapper;
    public FaktureController(IFakturaRepo repository, IMapper mapper)
    {
      _mapper = mapper;
      _repository = repository;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Fakture>> GetFacture(int id)
    {
      var facture = await _repository.GetFactureByIdAsync(id);

      if (facture != null)
      {
          return Ok(facture);
      }

      return NotFound();
    }

    [HttpGet]
    public async Task<ActionResult<List<Fakture>>> GetFactures()
    {
      var factures = await _repository.GetFacturesAsync();

      var data = _mapper.Map<List<Fakture>, List<FactureToReturnDto>>(factures);

      return Ok(data);
    }

    [HttpGet("products")]
    public async Task<ActionResult<List<FaktureProducts>>> GetFaktureProducts()
    {
      var factureProducts = await _repository.GetFactureProductsAsync();

      return Ok(factureProducts);
    }

    [HttpGet("status")]
    public async Task<ActionResult<List<FaktureStatus>>> GetFaktureStatus()
    {
      var factureStatus = await _repository.GetFactureStatusAsync();

      return Ok(factureStatus);
    }

    [HttpPost]
    public ActionResult<List<FactureToReturnDto>> CreateFacture(FactureToCreateDto factureCreateDto)
    {
      var factureModel = _mapper.Map<Fakture>(factureCreateDto);
      _repository.CreateFacture(factureModel);

      return Ok(factureModel);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteFakture(int id)
    {
      var faktureModelFromRepo = await _repository.GetFactureByIdAsync(id);

      if (faktureModelFromRepo == null)
      {
        return NotFound();
      }

      _repository.DeleteFacture(faktureModelFromRepo);
      _repository.SaveChanges();

      return NoContent();
    }
  }
}