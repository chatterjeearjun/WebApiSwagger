using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiSwagger.Api.v1.Models
{
    /// <summary>
    /// Represents an author model.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// A author id.
        /// </summary>
        /// <example>1</example>
        [Required]
        public int? Id { get; set; }

        /// <summary>
        /// A author name.
        /// </summary>
        /// <example>John</example>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// A author surname.
        /// </summary>
        /// <example>Smith</example>
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        /// <summary>
        /// A author birthdate.
        /// </summary>
        public DateTime? Birthdate { get; set; }
    }
}