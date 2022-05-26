using InterestingAlgorithms.BLL.Services.Intarface;
using InterestingAlgorithms.DTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InterestingAlgorithms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly ICalculatorService _calculatorServices;

        public AlgorithmsController(ICalculatorService calculatorServices)
        {
            _calculatorServices = calculatorServices;
        }

        [HttpPost("get-result-additions")]
        public async Task<ActionResult<GetResultAdditionsResponse>> GetResultAdditions(
            GetResultAdditionsRequest request,
            CancellationToken token)
        {
            var first = request.First;
            var second = request.Second;

            var result = await _calculatorServices.GetResultAdditions(first, second, token);

            var response = new GetResultAdditionsResponse
            {
                Result = result
            };

            return response;
        }
    }
}
