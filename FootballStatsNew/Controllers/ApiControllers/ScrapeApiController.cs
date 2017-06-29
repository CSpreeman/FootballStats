using FootballStatsNew.Services;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballStatsNew.Controllers.ApiControllers
{
    [RoutePrefix("scrape")]
    public class ScrapeApiController : ApiController
    {
        [Route("qb"), HttpGet]
        public HttpResponseMessage scrapeQBs()
        {
            List<int> scrapeQbs = ScrapeService.ScrapeData();
            return Request.CreateResponse(HttpStatusCode.OK, scrapeQbs);
        }
    }
}