using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using InterestingAlgorithms.BLL.Services.Intarface;
using InterestingAlgorithms.Grpc.Protos;

namespace InterestingAlgorithms.Grpc.Services
{
    public class AlgorithmsGrpcService:AlgorithmService.AlgorithmServiceBase
    {
        private readonly ICalculatorService _calculatorServices;

        public AlgorithmsGrpcService(ICalculatorService calculatorServices)
        {
            _calculatorServices = calculatorServices;
        }

        public override async Task<GetResultAdditionsResponse> GetResultAdditions(GetResultAdditionsRequest request, ServerCallContext context)
        {
            var first = request.First;
            var second = request.Second;

            var result = await _calculatorServices.GetResultAdditions(first, second, context.CancellationToken);

            var response = new GetResultAdditionsResponse
            {
                Result = result
            };

            return response;
        }
    }
}
