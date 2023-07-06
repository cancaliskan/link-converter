using LinkConverter.Application.Factories.Utils.WebUrlToDeepLink;

namespace LinkConverter.Application.Factories
{
    public class LinkConverterFactory
    {
        public static string GetConvertedLink(string link)
        {
            if (link.StartsWith(Constants.Web.BASE_URL))
            {
                return new WebUrlToDeepLinkFactory(link).GetConvertedLink();
            }

            return link;
        }
    }
}