using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MinimalApi;

public class AppDb : DbContext
{
    public AppDb(DbContextOptions<AppDb> options) : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; } = null!;
}


public class Post
{
    public string Id { get; set; } = null!;

    [Required]
    public string Content { get; set; } = null!;

    public string? ImageUrl { get; set; }
}