using System;
using System.Collections.Generic;

namespace BlogPost.Models;

public partial class Article
{
    public int ArticleId { get; set; }

    public int CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string Summary { get; set; } = null!;

    public int? ActiveFlag { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int CreatedAppId { get; set; }

    public int? LastUpdatedAppUserId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
