
using Domain.CommonEntity;

namespace Domain.Entities;

public class PostEntity : BaseEntity
{
    public Guid UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public int LikeCount { get; set; }
    public string PicturePath { get; set; } = string.Empty;
}