using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiSwagger.Api.v1.Models
{
    /// <summary>
    /// Represents a post model.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// A post id.
        /// </summary>
        /// <example>1</example>
        [Required]
        public int? Id { get; set; }

        /// <summary>
        /// A post title.
        /// </summary>
        /// <example>Captain America: The First Avenger</example>
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        /// <summary>
        /// A post content.
        /// </summary>
        /// <example>One of the original Avengers, and an all-time audience favorite</example>
        public string Content { get; set; }

        /// <summary>
        /// A post publish date.
        /// </summary>
        public DateTime? PublishDate { get; set; }

        /// <summary>
        /// A post tags.
        /// </summary>
        public IEnumerable<Tag> Tags { get; set; }

        /// <summary>
        /// A post author.
        /// </summary>
        public Author Author { get; set; }
    }
}