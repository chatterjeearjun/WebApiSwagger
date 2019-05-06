using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiSwagger.Api.v2.Models
{
    /// <summary>
    /// Represents a post model.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// A post id.
        /// </summary>
        /// <example>3</example>
        [Required]
        public int? Id { get; set; }

        /// <summary>
        /// A post title.
        /// </summary>
        /// <example>Captain Marvel</example>
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        /// <summary>
        /// A post content.
        /// </summary>
        /// <example>Captain Marvel is an extraterrestrial Kree warrior</example>
        public string Content { get; set; }

        /// <summary>
        /// A post publish date.
        /// </summary>
        public DateTime? PublishDate { get; set; }

        /// <summary>
        /// A post author.
        /// </summary>
        public Author Author { get; set; }
    }
}