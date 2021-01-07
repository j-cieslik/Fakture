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

  
  }
}