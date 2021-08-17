using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CP380_B2_BlockWebAPI.Models;

namespace CP380_B2_BlockWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PendingPayloadsController : ControllerBase
    {
        private readonly List<PendingPayloads> p;
        private PendingPayloadsList pl;

        public PendingPayloadsController()
        {
            var payloads = new List<PendingPayloads>();
            var payloadsList = new PendingPayloadsList();
            p = payloads;
            pl = payloadsList;
        }

        [HttpGet]
        public ActionResult<List<PendingPayloads>> Get() =>
            p.ToList();

        [HttpPost]
        public ActionResult<PendingPayloads> Post(PendingPayloads payload)
        {
            return pl.Add(payload);
        }
    }
}
