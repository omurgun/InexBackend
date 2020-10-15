using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Noio.Inex.Business.Abstract;
using Noio.Inex.Business.DependencyResolvers.Ninject;
using Noio.Inex.Entities.FullData;

namespace Noio.Inex.WebApi.Controllers
{
    public class DataController : ApiController
    {
        private IDataService _dataService = InstanceFactory.GetInstance<IDataService>();

        [ResponseType(typeof(Data))]
        [HttpPost]
        public IHttpActionResult PostUserRegister(Data data)
        {
            _dataService.AddData(data);
            return CreatedAtRoute("DefaultApi", new { id = data.Game }, data);
        }
    }
}
