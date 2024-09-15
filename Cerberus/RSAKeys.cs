using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace Cerberus
{
    internal class RSAKeys
    {
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(RSAKeys.resourceMan, null))
                {
                    RSAKeys.resourceMan = new ResourceManager("Cerberus.RSAKeys", typeof(RSAKeys).Assembly);
                }
                return RSAKeys.resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return RSAKeys.resourceCulture;
            }
            set
            {
                RSAKeys.resourceCulture = value;
            }
        }

        internal static byte[] XMACS_RSA_PUB2048
        {
            get
            {
                return (byte[])ResourceManager.GetObject("XMACS_RSA_PUB2048", resourceCulture);
            }
        }

        internal RSAKeys()
        {
        }

        private static ResourceManager resourceMan;

        private static CultureInfo resourceCulture;
    }
}
