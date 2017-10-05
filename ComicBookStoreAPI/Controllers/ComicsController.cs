
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ComicBookStoreAPI.Logic;

namespace ComicBookStoreAPI.Controllers
{
    /// <summary>
    /// The Comics Endpoint Controller
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [Route("api/comics")]
    public class ComicsController : ApiController
    {
        private readonly ComicLogic _comicLogic;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComicsController"/> class.
        /// </summary>
        public ComicsController()
        {
            _comicLogic = new ComicLogic();
        }

        /// <summary>
        /// Gets the comics.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage GetComics(HttpRequestMessage request) => request.CreateResponse(HttpStatusCode.OK, _comicLogic.GetComics());
    }
}