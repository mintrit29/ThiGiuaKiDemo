using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ThiGiuaKiDemo.Models;

[Table("Book")]
public partial class Book
{
    [Key]
    public int BookId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CoverImagePath { get; set; }

    public int AuthorId { get; set; }

    [ForeignKey("AuthorId")]
    [InverseProperty("Books")]
    public virtual Author ?Author { get; set; }
}
