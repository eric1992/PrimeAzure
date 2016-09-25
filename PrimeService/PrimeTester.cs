using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mpir.NET;

namespace PrimeService
{
  public class PrimeTester : IPrimeTester
  {
    private IPrimeGenerator PrimeGenerator;

    public PrimeTester(IPrimeGenerator primeGenerator)
    {
      PrimeGenerator = primeGenerator;
    }

    public bool IsPrime(mpz_t i)
    {
      throw new NotImplementedException();
    }

    public bool IsPrime(int i)
    {
      if (i <= 1) return false;
      var maxPossibleDivisor = Convert.ToInt32(Math.Floor(Math.Sqrt(i)));
      return PrimeGenerator.GetPrimesInRange(2, maxPossibleDivisor).All(divisor => i % divisor != 0);
    }
  }
}
