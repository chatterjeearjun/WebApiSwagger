using Microsoft.Web.Http;
using System;
using System.Web.Http;
using WebApiSwagger.Api.v2.Models;

namespace WebApiSwagger.Api.v2.Controllers
{
    /// <summary>
    /// Represents a RESTful service of posts.
    /// </summary>
    [ApiVersion("2.0")]
    [RoutePrefix("api/v{version:apiVersion}/posts")]
    public class PostsController : ApiController
    {
        /// <summary>
        /// Gets all posts.
        /// </summary>
        /// <returns>All founded posts.</returns>
        [HttpGet, Route]
        public IHttpActionResult Get()
        {
            var posts = new[]
            {
                new Post
                {
                    Id = 3,
                    Title = "Captain Marvel",
                    Content = "Captain Marvel is an extraterrestrial Kree warrior...",
                    PublishDate = DateTime.UtcNow,
                    Author = new Author { Id = 3, Name = "Tim", Surname = "Warner" }
                },
                new Post
                {
                    Id = 4,
                    Title = "Avengers: Infinity War",
                    Content = "The Avengers and all forces of good must come together to stop Thanos...",
                    PublishDate = DateTime.UtcNow.AddDays(-1),
                    Author = new Author { Id = 4, Name = "Jack", Surname = "Anderson" }
                },
            };

            return Ok(posts);
        }

        /// <summary>
        /// Gets a specific post.
        /// </summary>
        /// <param name="id">Post identifier.</param>
        /// <returns>A specific post.</returns>
        [HttpGet, Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var post = new Post
            {
                Id = id,
                Title = "Captain Marvel",
                Content = "Captain Marvel is an extraterrestrial Kree warrior...",
                PublishDate = DateTime.UtcNow,
                Author = new Author { Id = 3, Name = "Tim", Surname = "Warner" }
            };

            return Ok(post);
        }

        /// <summary>
        /// Posts a new post.
        /// </summary>
        /// <param name="post">Post model.</param>
        /// <returns>A new post.</returns>
        [HttpPost, Route]
        public IHttpActionResult Post([FromBody] Post post)
        {
            if (ModelState.IsValid)
            {
                return Ok(post);
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Deletes a specific post.
        /// </summary>
        /// <param name="id">Post identifier.</param>
        /// <returns>A deleted post.</returns>
        [HttpDelete, Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var post = new Post
            {
                Id = id,
                Title = "Captain Marvel",
                Content = "Captain Marvel is an extraterrestrial Kree warrior...",
                PublishDate = DateTime.UtcNow,
                Author = new Author { Id = 3, Name = "Tim", Surname = "Warner" }
            };

            return Ok(post);
        }
    }
}
