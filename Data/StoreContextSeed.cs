using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Models;

namespace API.Data
{
  public class StoreContextSeed
  {
    public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
    {
      try
      {
        if (!context.FaktureProducts.Any())
        {
          var productsData = File.ReadAllText("../API/Data/SeedData/products.json");

          var products = JsonSerializer.Deserialize<List<FaktureProducts>>(productsData);

          foreach (var item in products)
          {
            context.FaktureProducts.Add(item);
          }

          await context.SaveChangesAsync();
        }

        if (!context.FaktureStatus.Any())
        {
          var statusData = File.ReadAllText("../API/Data/SeedData/status.json");

          var statuses = JsonSerializer.Deserialize<List<FaktureStatus>>(statusData);

          foreach (var item in statuses)
          {
            context.FaktureStatus.Add(item);
          }

          await context.SaveChangesAsync();
        }

        if (!context.Fakture.Any())
        {
          var faktureData = File.ReadAllText("../API/Data/SeedData/fakture.json");

          var faktures = JsonSerializer.Deserialize<List<Fakture>>(faktureData);

          foreach (var item in faktures)
          {
            context.Fakture.Add(item);
          }

          await context.SaveChangesAsync();
        }
      }
      catch (Exception ex)
      {
        var logger = loggerFactory.CreateLogger<StoreContextSeed>();
        logger.LogError(ex.Message);
      }
    }
  }
}