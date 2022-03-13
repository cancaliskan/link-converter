using LinkConverter.Domain.Common;

namespace LinkConverter.Domain.Entities
{
    public sealed class ConvertedLink : BaseEntity
    {
        public string WebUrl { get; set; }
        public string DeepLink { get; set; }
    }
}