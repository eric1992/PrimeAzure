using Mpir.NET;
using System.Collections.Generic;

namespace PrimeService
{
  interface IPrimeGenerator
  {
    mpz_t Get(int i);
    mpz_t Get(mpz_t i);
    IEnumerable<mpz_t> GetBetween(int i, int j);
    IEnumerable<mpz_t> GetBetween(mpz_t i, mpz_t j);
  }
}
