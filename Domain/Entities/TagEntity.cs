using Domain.CommonEntity;

namespace Domain.Entities;

public class TagEntity : BaseEntity
{
    public string Name { get; set; } = null!;
    // public List<PostEntity> Posts { get; set; } = null!;
}