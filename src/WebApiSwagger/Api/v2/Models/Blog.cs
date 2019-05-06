using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiSwagger.Api.v2.Models
{
    /// <summary>
    /// Represents a blog model.
    /// </summary>
    public class Blog
    {
        /// <summary>
        /// A blog id.
        /// </summary>
        /// <example>3</example>
        [Required]
        public int? Id { get; set; }

        /// <summary>
        /// A blog name.
        /// </summary>
        /// <example>Mashable</example>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// A blog posts.
        /// </summary>
        public IEnumerable<Post> Posts { get; set; }
    }
}