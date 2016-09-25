using Mpir.NET;

namespace PrimeService
{
  interface IPrimeTester
  {
    bool IsPrime(int i);
    bool IsPrime(mpz_t i);
  }
}
