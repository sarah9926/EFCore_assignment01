using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_assignment01.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int BookCode { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string ISBN { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public int NumberOfPages { get; set; }

        public int PublicationYear { get; set; }

        public bool IsInStock { get; set; } 
        public int AuthorId { get; set; }

        public int CategoryId { get; set; }

        
        public Author Author { get; set; } = null!;

        public Category Category { get; set; } = null!;
    }
}
