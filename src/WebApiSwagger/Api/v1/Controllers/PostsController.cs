using Microsoft.Web.Http;
using System;
using System.Web.Http;
using WebApiSwagger.Api.v1.Models;

namespace WebApiSwagger.Api.v1.Controllers
{
    /// <summary>
    /// Represents a RESTful service of posts.
    /// </summary>
    [ApiVersion("1.0", Deprecated = true)]
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
                    Id = 1,
                    Title = "Captain America: The First Avenger",
                    Content = "One of the original Avengers, and an all-time audience favorite...",
                    PublishDate = DateTime.UtcNow,
                    Author = new Author { Id = 1, Name = "John", Surname = "Smith" }
                },
                new Post
                {
                    Id = 2,
                    Title = "Avengers: Endgame",
                    Content = "Currently it stands at $2.188B making it the second highest grossing film worldwide...",
                    PublishDate = DateTime.UtcNow.AddDays(-1),
                    Author = new Author { Id = 2, Name = "Bob", Surname = "William" }
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
                Title = "Captain America: The First Avenger",
                Content = "One of the original Avengers, and an all-time audience favorite...",
                PublishDate = DateTime.UtcNow,
                Author = new Author { Id = 1, Name = "John", Surname = "Smith" }
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
                Title = "Captain America: The First Avenger",
                Content = "One of the original Avengers, and an all-time audience favorite...",
                PublishDate = DateTime.UtcNow,
                Author = new Author { Id = 1, Name = "John", Surname = "Smith" }
            };

            return Ok(post);
        }
    }
}
