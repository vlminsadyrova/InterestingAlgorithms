using System.Threading.Tasks;
using AlgorithmsGrpc;
using Grpc.Core;
using InterestingAlgorithms.BLL.Services.Intarface;

namespace AlgorithmsGrpc
{
    public class AlgorithmsService : Algorithms.AlgorithmsBase
    {
        private readonly ICalculatorService _calculatorServices;

        public AlgorithmsService(ICalculatorService calculatorServices)
        {
            _calculatorServices = calculatorServices;
        }

        public override async Task<GetResultAdditionsResponse> GetResultAdditions(GetResultAdditionsRequest request, ServerCallContext context)
        {
            var result = await _calculatorServices.GetResultAdditions(request.First, request.Second, token: context.CancellationToken);

            return new GetResultAdditionsResponse
            {
                Result = result
            };
        }
    }
}
