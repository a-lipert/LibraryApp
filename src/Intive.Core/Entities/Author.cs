﻿using Intive.Core.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intive.Core.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

    }
}
