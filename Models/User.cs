using System;
using System.Collections.Generic;

namespace BlogPost.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? ActiveFlag { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int CreatedAppId { get; set; }

    public int? LastUpdatedAppUserId { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
