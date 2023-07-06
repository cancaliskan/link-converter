namespace LinkConverter.Application.Constants
{
    public static class Web
    {
        public static string BASE_URL = "https://www.trendyol.com";
        public static string SEARCH = "/sr?q=";
        public static string BOUTIQUE = "boutiqueId=";
        public static string MERCHANT = "merchantId=";
        public static string PRODUCT = "/brand/name-p-";
        public static string PRODUCT_IDENTIFIER = "-p-";
    }

    public static class Deep
    {
        public static string BASE_URL = "ty://?Page=";
        public static string HOME = "Home";
        public static string PRODUCT = "Product&ContentId=";
        public static string SEARCH = "Search&Query=";
        public static string CAMPOIGN = "CampaignId=";
        public static string CONTENT = "ContentId=";
        public static string MERHANT = "MerchantId=";
    }

    public static class General
    {
        public static string PARAMETER_SEPARATOR = "&";
        public static string QUESTION_MARK = "?";
        public static string EQUALS_SIGN = "=";
        public static string SEARCH = "Search";
        public static string END_OF_STRING = "/#";
    }

    public static class Parameters
    {
        public static string PAGE = "Page=";
        public static string QUERY = "Query=";
    }
}