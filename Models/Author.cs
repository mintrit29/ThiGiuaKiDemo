using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ThiGiuaKiDemo.Models;

[Table("Author")]
public partial class Author
{
    [Key]
    public int AuthorId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Bio { get; set; }

    [InverseProperty("Author")]
    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
