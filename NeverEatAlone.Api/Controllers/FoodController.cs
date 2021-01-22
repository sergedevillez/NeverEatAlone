using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeverEatAlone.Models.Client.Entities;
using NeverEatAlone.Models.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeverEatAlone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodRepository<Food> _repository;

        public FoodController(IFoodRepository<Food> repository)
        {
            _repository = repository;
        }


    }
}
