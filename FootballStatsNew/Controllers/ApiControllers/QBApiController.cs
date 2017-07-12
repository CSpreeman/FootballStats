using FootballStatsNew.Models;
using FootballStatsNew.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballStatsNew.Controllers.ApiControllers
{
    [RoutePrefix("api/qb")]
    public class QBApiController : ApiController
    {
        [Route, HttpGet]
        public HttpResponseMessage getQbs()
        {
            List<Quarterback> QBList = QBService.GetQBs();
            return Request.CreateResponse(HttpStatusCode.OK, QBList);
        }

    }
}
