using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiSwagger.Api.v1.Models
{
    /// <summary>
    /// Represents a tag model.
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// A tag id.
        /// </summary>
        /// <example>1</example>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// A tag name.
        /// </summary>
        /// <example>Movies</example>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// A tag posts.
        /// </summary>
        public IEnumerable<Post> Posts { get; set; }
    }
}