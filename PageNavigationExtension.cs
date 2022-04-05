namespace Shop.Automation.Framework
{
    public static class PageNavigationExtension
    {
        public static string Land(this Page page)
        {
            return page.StartWithUrl(page.Path);
        }

        public static string LandOnAlternativePath(this Page page)
        {
            return page.StartWithUrl(page.AlternativePath);
        }

        public static string LandOnTargetedURL(this Page page)
        {
            return page.StartWithTargetedUrl(page.RelativePath);
        }
    }
}
