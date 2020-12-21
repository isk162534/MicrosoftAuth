namespace MicrosoftAuth.OAuth
{
    public class PreAuthResponse
    {
        public PreAuthResponse(string cookie, string ppft, string urlpost)
        {
            this.Cookie = cookie;
            this.PPFT = ppft;
            this.UrlPost = urlpost;
        }

        public string Cookie { get; private set; }
        public string PPFT { get; private set; }
        public string UrlPost { get; private set; }
    }
}
