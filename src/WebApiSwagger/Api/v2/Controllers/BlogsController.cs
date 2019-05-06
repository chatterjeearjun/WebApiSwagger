using Microsoft.Web.Http;
using System.Web.Http;
using WebApiSwagger.Api.v2.Models;

namespace WebApiSwagger.Api.v2.Controllers
{
    /// <summary>
    /// Represents a RESTful service of blogs.
    /// </summary>
    [ApiVersion("2.0")]
    [RoutePrefix("api/v{version:apiVersion}/blogs")]
    public class BlogsController : ApiController
    {
        /// <summary>
        /// Gets all blogs.
        /// </summary>
        /// <returns>All founded blogs.</returns>
        [HttpGet, Route]
        public IHttpActionResult Get()
        {
            var blogs = new[]
            {
                new Blog
                {
                    Id = 3,
                    Name = "Mashable",
                    Posts = new []
                    {
                        new Post { Id = 3, Title = "Captain Marvel" },
                        new Post { Id = 4, Title = "Avengers: Infinity War" }
                    }
                },
                new Blog
                {
                    Id = 4,
                    Name = "Gizmodo",
                    Posts = new []
                    {
                        new Post { Id = 3, Title = "Captain Marvel" },
                        new Post { Id = 4, Title = "Avengers: Infinity War" }
                    }
                },
            };

            return Ok(blogs);
        }

        /// <summary>
        /// Gets a specific blog.
        /// </summary>
        /// <param name="id">Blog identifier.</param>
        /// <returns>A specific blog.</returns>
        [HttpGet, Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var blog = new Blog
            {
                Id = id,
                Name = "Mashable",
                Posts = new[]
                {
                    new Post { Id = 3, Title = "Captain Marvel" },
                    new Post { Id = 4, Title = "Avengers: Infinity War" }
                }
            };

            return Ok(blog);
        }

        /// <summary>
        /// Posts a new blog.
        /// </summary>
        /// <param name="blog">Blog model.</param>
        /// <returns>A new blog.</returns>
        [HttpPost, Route]
        public IHttpActionResult Post([FromBody] Blog blog)
        {
            if (ModelState.IsValid)
            {
                return Ok(blog);
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Deletes a specific blog.
        /// </summary>
        /// <param name="id">Blog identifier.</param>
        /// <returns>A deleted blog.</returns>
        [HttpDelete, Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var blog = new Blog
            {
                Id = id,
                Name = "Mashable",
                Posts = new[]
                {
                    new Post { Id = 3, Title = "Captain Marvel" },
                    new Post { Id = 4, Title = "Avengers: Infinity War" }
                }
            };

            return Ok(blog);
        }
    }
}
