namespace CPMobile.Helper
{
    public static class StringHelper
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        public static string HttpUrlFix(this string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            if(value.Contains("http"))
            {
                return value;
            }
            else
            {
                return string.Format("http:{0}", value);
            }
        }
    }
}
