using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Algorithms
    {
        /// <summary>
        /// Find an index P such as A[0] + ... + A[P-1] == A[P+1] + ... + A[N].
        /// Complexity is O(N), N - array length.
        /// NOTE: method returns only first equilibrium point found; if it doesn't exists, output is -1
        /// </summary>
        /// <param name="A">Input array</param>
        /// <returns></returns>
        public int EquilibriumIndex(int[] A)
        {
            if (A.Length == 0)
            {
                return -1;
            }

            var sum = A.Sum(x => (long)x);
            long currentLeftSum = 0;

            for (int i = 0; i < A.Length; ++i)
            {
                var rightSum = sum - A[i] - currentLeftSum;
                if (rightSum == currentLeftSum) return i;

                currentLeftSum += A[i];
            }

            return -1;
        }
    }
}
