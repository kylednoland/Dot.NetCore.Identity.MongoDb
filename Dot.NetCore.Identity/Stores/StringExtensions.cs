using System;

namespace Dot.NetCore.Identity.Stores
{
    public static class StringExtensions
    {
        public static bool IsGuid(this string text)
        {
            return Guid.TryParse(text, out var _);
        }
    }
}