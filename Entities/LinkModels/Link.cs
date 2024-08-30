namespace Entities.LinkModels
{
    public class Link
    {
        public string? Href;
        public string? Rel;
        public string? Method;

        public Link()
        {
        }

        public Link(string href, string rel, string method)
        {
            Href = href;
            Rel = rel;
            Method = method;
        }
    }
}
