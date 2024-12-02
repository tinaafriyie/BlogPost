using System;
using System.Collections.Generic;

namespace BlogPost.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public int? ActiveFlag { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int CreatedAppId { get; set; }

    public int? LastUpdatedAppUserId { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
}
