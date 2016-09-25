using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PrimeAzure.Controllers
{
    [RoutePrefix("IntegerTests")]
    public class IntegerTestsController : ApiController
    {
        [HttpGet]
        [Route(@"IsPrime/{value}")]
        public object IsPrime(int value)
        {
            return new
            {
                value = value,
                result = PrimeService.Primes.IsPrime(value)
            };
        }
    }
}
