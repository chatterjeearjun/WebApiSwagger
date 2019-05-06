using Microsoft.Web.Http;
using System.Web.Http;
using WebApiSwagger.Api.v1.Models;

namespace WebApiSwagger.Api.v1.Controllers
{
    /// <summary>
    /// Represents a RESTful service of blogs.
    /// </summary>
    [ApiVersion("1.0", Deprecated = true)]
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
                    Id = 1,
                    Name = "Reddit",
                    Posts = new[]
                    {
                        new Post { Id = 1, Title = "Captain America: The First Avenger" },
                        new Post { Id = 2, Title = "Avengers: Endgame" }
                    }
                },
                new Blog
                {
                    Id = 2,
                    Name = "TechCrunch",
                    Posts = new[]
                    {
                        new Post { Id = 1, Title = "Captain America: The First Avenger" },
                        new Post { Id = 2, Title = "Avengers: Endgame" }
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
                Name = "Reddit",
                Posts = new[]
                {
                    new Post { Id = 1, Title = "Captain America: The First Avenger" },
                    new Post { Id = 2, Title = "Avengers: Endgame" }
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
                Name = "Reddit",
                Posts = new[]
                {
                    new Post { Id = 1, Title = "Captain America: The First Avenger" },
                    new Post { Id = 2, Title = "Avengers: Endgame" }
                }
            };

            return Ok(blog);
        }
    }
}
