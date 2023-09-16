using Domain.CommonEntity;

namespace Domain.Entities
{
    public class CommentEntity : BaseEntity
    {
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; } = null!;

        // public UserEntity User { get; set; } = null!;
        // public PostEntity Post { get; set; } = null!;
    }
}