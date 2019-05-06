using Microsoft.Web.Http;
using System.Web.Http;
using WebApiSwagger.Api.v2.Models;

namespace WebApiSwagger.Api.v2.Controllers
{
    /// <summary>
    /// Represents a RESTful service of authors.
    /// </summary>
    [ApiVersion("2.0")]
    [RoutePrefix("api/v{version:apiVersion}/authors")]
    public class AuthorsController : ApiController
    {
        /// <summary>
        /// Gets all authors.
        /// </summary>
        /// <returns>All founded authors.</returns>
        [HttpGet, Route]
        public IHttpActionResult Get()
        {
            var authors = new[]
            {
                new Author { Id = 1, Name = "John", Surname = "Smith" },
                new Author { Id = 2, Name = "Bob", Surname = "William"},
                new Author { Id = 3, Name = "Tim", Surname = "Warner"},
                new Author { Id = 4, Name = "Jack", Surname = "Anderson"},
            };

            return Ok(authors);
        }

        /// <summary>
        /// Gets a specific author.
        /// </summary>
        /// <param name="id">Author identifier.</param>
        /// <returns>A specific author.</returns>
        [HttpGet, Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var author = new Author
            {
                Id = id,
                Name = "John",
                Surname = "Smith"
            };

            return Ok(author);
        }

        /// <summary>
        /// Posts a new author.
        /// </summary>
        /// <param name="author">Author model.</param>
        /// <returns>A new author.</returns>
        [HttpPost, Route]
        public IHttpActionResult Post([FromBody] Author author)
        {
            if (ModelState.IsValid)
            {
                return Ok(author);
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Deletes a specific author.
        /// </summary>
        /// <param name="id">Author identifier.</param>
        /// <returns>A deleted author.</returns>
        [HttpDelete, Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var author = new Author
            {
                Id = id,
                Name = "John",
                Surname = "Smith"
            };

            return Ok(author);
        }
    }
}
