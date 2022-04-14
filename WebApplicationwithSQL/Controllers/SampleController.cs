using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationwithSQL.Models;


namespace WebApplicationWithSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly SampledbContext SampleDbContext;

        public SampleController(SampledbContext _sampleDbContext)
        {
            SampleDbContext = _sampleDbContext;
        }

        [HttpGet]
        public IEnumerable<TblSample> Get()
        {
            return SampleDbContext.TblSamples.ToList();
        }
    }
}