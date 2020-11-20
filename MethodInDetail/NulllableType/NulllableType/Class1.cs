using System;

namespace NulllableType
{
    public static class Nulll
    {
        public static bool isNull(this string s)
        {
            return (object)s == null;

        }

        public static bool isNullinteger(this int s)
        {
            return (object)s == null;

        }
    }
}
