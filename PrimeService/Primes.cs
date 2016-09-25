using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeService
{
  public class Primes : IEnumerable<int>
  {
    public IEnumerator<int> GetEnumerator()
    {
      throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }

    public static bool IsPrime(int i)
    {
      if (i <= 1) return false;
      var maxPossibleDivisor = Convert.ToInt32(Math.Floor(Math.Sqrt(i)));
      return Enumerable.Range(2, maxPossibleDivisor).All(divisor => i % divisor != 0);
    }
  }
}
