using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerberus
{
    internal class Resources
    {
        private static CultureInfo resourceCulture;
        private static System.Resources.ResourceManager resourceMan;

        internal Resources()
        {
        }

        internal static byte[] apReq1
        {
            get
            {
                return (byte[])ResourceManager.GetObject("apReq1", resourceCulture);
            }
        }

        internal static byte[] apreq2
        {
            get
            {
                return (byte[])ResourceManager.GetObject("apreq2", resourceCulture);
            }
        }

        internal static byte[] APRESP
        {
            get
            {
                return (byte[])ResourceManager.GetObject("APRESP", resourceCulture);
            }
        }

        internal static byte[] authenticator
        {
            get
            {
                return (byte[])ResourceManager.GetObject("authenticator", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        internal static byte[] macsresp
        {
            get
            {
                return (byte[])ResourceManager.GetObject("macsresp", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    System.Resources.ResourceManager manager = new System.Resources.ResourceManager("Cerberus.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = manager;
                }
                return resourceMan;
            }
        }

        internal static byte[] resp
        {
            get
            {
                return (byte[])ResourceManager.GetObject("resp", resourceCulture);
            }
        }

        internal static byte[] servicereq
        {
            get
            {
                return (byte[])ResourceManager.GetObject("servicereq", resourceCulture);
            }
        }

        internal static byte[] test
        {
            get
            {
                return (byte[])ResourceManager.GetObject("test", resourceCulture);
            }
        }

        internal static byte[] TGSREQ
        {
            get
            {
                return (byte[])ResourceManager.GetObject("TGSREQ", resourceCulture);
            }
        }

        internal static byte[] tgsres
        {
            get
            {
                return (byte[])ResourceManager.GetObject("tgsres", resourceCulture);
            }
        }

        internal static byte[] tgsresp
        {
            get
            {
                return (byte[])ResourceManager.GetObject("tgsresp", resourceCulture);
            }
        }

        internal static byte[] XMACSREQ
        {
            get
            {
                return (byte[])ResourceManager.GetObject("XMACSREQ", resourceCulture);
            }
        }
    }
}
