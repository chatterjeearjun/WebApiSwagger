using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiSwagger.Api.v2.Models
{
    /// <summary>
    /// Represents an author model.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// A author id.
        /// </summary>
        /// <example>3</example>
        [Required]
        public int? Id { get; set; }

        /// <summary>
        /// A author name.
        /// </summary>
        /// <example>Tim</example>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// A author surname.
        /// </summary>
        /// <example>Warner</example>
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        /// <summary>
        /// A author birthdate.
        /// </summary>
        public DateTime? Birthdate { get; set; }
    }
}