using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mpir.NET;

namespace PrimeService
{
  public class PrimeGenerator : IPrimeGenerator
  {
    private IEnumerable<int> Primes;
    public mpz_t Get(mpz_t i)
    {
      throw new NotImplementedException();
    }

    public mpz_t Get(int i)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<mpz_t> GetBetweenIndexes(mpz_t i, mpz_t j)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<mpz_t> GetBetweenIndexes(int i, int j)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<mpz_t> GetPrimesInRange(mpz_t lowerBound, mpz_t upperBound)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<int> GetPrimesInRange(int lowerBound, int upperBound)
    {
      throw new NotImplementedException();
    }
  }
}
