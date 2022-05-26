using InterestingAlgorithms.BLL.Services.Intarface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InterestingAlgorithms.BLL.Services
{
    public class CalculatorService : ICalculatorService
    {
        public async Task<int> GetResultAdditions(int first, int second, CancellationToken token)
        {
            var result = first + second;
            return result;
        }

        public async Task<int> GetResultSubtraction(int first, int second, CancellationToken token)
        {
            var result = first - second;
            return result;
        }

        public async Task<int> GetResultMultiplication(int first, int second, CancellationToken token)
        {
            var result = first * second;
            return result;
        }

        public async Task<int> GetResultDivision(int first, int second, CancellationToken token)
        {
            var result = first / second;
            return result;
        }
    }
}
