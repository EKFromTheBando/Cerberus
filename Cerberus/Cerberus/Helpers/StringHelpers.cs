using System.IO;

namespace Cerberus.Cerberus.Helpers
{
    internal static class StringHelpers
    {
        public static string RemoveInvalidChars(this string fileName)
        {
            if (fileName.IsNullOrWhiteSpace())
            {
                return null;
            }

            return string.Join(string.Empty, fileName.Split(Path.GetInvalidFileNameChars()));
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

    }
}
