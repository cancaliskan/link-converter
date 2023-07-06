namespace LinkConverter.Application.Factories.Helpers
{
    public static class WebUrlToDeepLinkHelper
    {
        public static string GenerateProductPageUrl(string link)
        {
            var contentId = link.Substring(link.LastIndexOf('p') + 2);
            var boutiqueId = string.Empty;
            var merchantId = string.Empty;
            if (contentId.Contains(Constants.General.QUESTION_MARK))
            {
                var parametersOfLink = link.Substring(link.LastIndexOf(Constants.General.QUESTION_MARK) + 1);
                if (parametersOfLink.Contains(Constants.Web.BOUTIQUE) && parametersOfLink.Contains(Constants.Web.MERCHANT))
                {
                    if (parametersOfLink.StartsWith(Constants.Web.BOUTIQUE))
                    {
                        boutiqueId = parametersOfLink.Substring(parametersOfLink.IndexOf(Constants.General.EQUALS_SIGN) + 1);
                        merchantId = boutiqueId.Substring(boutiqueId.IndexOf(Constants.General.EQUALS_SIGN) + 1);
                        boutiqueId = boutiqueId.Substring(0, boutiqueId.IndexOf(Constants.General.PARAMETER_SEPARATOR));
                    }
                    else if (parametersOfLink.StartsWith(Constants.Web.MERCHANT))
                    {
                        merchantId = parametersOfLink.Substring(parametersOfLink.IndexOf(Constants.General.EQUALS_SIGN) + 1);
                        boutiqueId = merchantId.Substring(merchantId.IndexOf(Constants.General.EQUALS_SIGN) + 1);
                        merchantId = merchantId.Substring(0, merchantId.IndexOf(Constants.General.PARAMETER_SEPARATOR));
                    }
                }
                else if (parametersOfLink.Contains(Constants.Web.BOUTIQUE))
                {
                    boutiqueId = parametersOfLink.Substring(link.LastIndexOf(Constants.General.EQUALS_SIGN) + 1);
                }
                else if (parametersOfLink.Contains(Constants.Web.MERCHANT))
                {
                    merchantId = parametersOfLink.Substring(link.LastIndexOf(Constants.General.EQUALS_SIGN) + 1);
                }

                contentId = contentId.Substring(0, contentId.IndexOf(Constants.General.QUESTION_MARK));
            }

            var deepLink = Constants.Deep.BASE_URL +
                           Constants.Deep.PRODUCT +
                           contentId;
            if (!string.IsNullOrEmpty(boutiqueId) && !string.IsNullOrEmpty(merchantId))
            {
                deepLink += Constants.General.PARAMETER_SEPARATOR + Constants.Deep.CAMPOIGN + boutiqueId;
                deepLink += Constants.General.PARAMETER_SEPARATOR + Constants.Deep.MERHANT + merchantId;
            }
            else if (!string.IsNullOrEmpty(boutiqueId))
            {
                deepLink += Constants.General.PARAMETER_SEPARATOR + Constants.Deep.CAMPOIGN + boutiqueId;
            }
            else if (!string.IsNullOrEmpty(merchantId))
            {
                deepLink += Constants.General.PARAMETER_SEPARATOR + Constants.Deep.MERHANT + merchantId;
            }

            return deepLink;
        }

        public static string GenerateSearchPageUrl(string link)
        {
            return Constants.Deep.BASE_URL +
                   Constants.General.SEARCH +
                   Constants.General.PARAMETER_SEPARATOR +
                   Constants.Parameters.QUERY +
                   link.Substring(link.LastIndexOf('q') + 2);
        }

        public static string GenerateOtherPageUrl()
        {
            return Constants.Deep.BASE_URL + Constants.Deep.HOME;
        }
    }
}