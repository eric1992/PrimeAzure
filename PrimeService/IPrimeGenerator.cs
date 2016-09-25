using Mpir.NET;
using System.Collections.Generic;

namespace PrimeService
{
  public interface IPrimeGenerator
  {
    mpz_t Get(int i);
    mpz_t Get(mpz_t i);
    IEnumerable<mpz_t> GetBetweenIndexes(int i, int j);
    IEnumerable<mpz_t> GetBetweenIndexes(mpz_t i, mpz_t j);
    IEnumerable<int> GetPrimesInRange(int lowerBound, int upperBound);
    IEnumerable<mpz_t> GetPrimesInRange(mpz_t lowerBound, mpz_t upperBound); 
  }
}
