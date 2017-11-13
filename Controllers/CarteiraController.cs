using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AuthExample.API;
using AuthExample.Models;
using System.Threading.Tasks;

namespace AuthExample.Controllers
{
    [RoutePrefix("api/Carteira")]
    public class CarteiraController : ApiController
    {
        private AuthRepository _repo = null;

        public CarteiraController()
        {
            _repo = new AuthRepository();
        }

/*        [Authorize]
        [Route("ListaItens")]
        public IHttpActionResult ListaItens(string usuario)
        {
            return Ok(_repo.ListaItens(usuario));
        }
*/    }
}
