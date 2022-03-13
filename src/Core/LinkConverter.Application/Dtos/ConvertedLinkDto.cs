namespace LinkConverter.Application.Dtos
{
    public sealed class ConvertedLinkDto : BaseDto
    {
        public string WebUrl { get; set; }
        public string DeepLink { get; set; }
    }
}