using LinkConverter.Application.Factories.Helpers;

namespace LinkConverter.Application.Factories.Utils.WebUrlToDeepLink
{
    public class WebUrlToDeepLinkFactory
    {
        public string Link { get; set; }

        public WebUrlToDeepLinkFactory(string link)
        {
            Link = link;
        }

        public string GetConvertedLink()
        {
            if (Link.StartsWith(Constants.Web.BASE_URL) && Link.Contains(Constants.Web.PRODUCT_IDENTIFIER))
            {
                return WebUrlToDeepLinkHelper.GenerateProductPageUrl(Link);
            }
            else if (Link.StartsWith(string.Concat(Constants.Web.BASE_URL, Constants.Web.SEARCH)))
            {
                return WebUrlToDeepLinkHelper.GenerateSearchPageUrl(Link);
            }
            else
            {
                return WebUrlToDeepLinkHelper.GenerateOtherPageUrl();
            }
        }
    }
}