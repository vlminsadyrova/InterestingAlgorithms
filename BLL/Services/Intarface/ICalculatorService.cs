using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InterestingAlgorithms.BLL.Services.Intarface
{
    public interface ICalculatorService
    {
        Task<int> GetResultAdditions(int first, int second, CancellationToken token);

        Task<int> GetResultSubtraction(int first, int second, CancellationToken token);

        Task<int> GetResultMultiplication(int first, int second, CancellationToken token);

        Task<int> GetResultDivision(int first, int second, CancellationToken token);
    }
}
