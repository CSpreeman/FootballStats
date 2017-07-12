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
            string pos = "QUARTERBACK";
            List<int> scrapeQbs = ScrapeService.ScrapeData(pos);
            return Request.CreateResponse(HttpStatusCode.OK, scrapeQbs);
        }
        [Route("rb"), HttpGet]
        public HttpResponseMessage scrapeRBs()
        {
            string pos = "RUNNING_BACK";
            List<int> scrapeQbs = ScrapeService.ScrapeData(pos);
            return Request.CreateResponse(HttpStatusCode.OK, scrapeQbs);
        }
    }
}