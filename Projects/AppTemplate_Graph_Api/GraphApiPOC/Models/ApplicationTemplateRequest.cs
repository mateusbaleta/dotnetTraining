namespace GraphApiTemplate.Models
{
    public class ApplicationTemplateRequest
    {
        public string DisplayName { get; set; } = string.Empty;
        public string IdentifierUris { get; set; } = string.Empty;
        public string RedirectUri { get; set; } = string.Empty;
    }
}