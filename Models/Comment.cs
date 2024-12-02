using System;
using System.Collections.Generic;

namespace BlogPost.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public string Content { get; set; } = null!;

    public int? PostId { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? ActiveFlag { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int CreatedAppId { get; set; }

    public int? LastUpdatedAppUserId { get; set; }

    public virtual Article? Post { get; set; }

    public virtual User? User { get; set; }
}
