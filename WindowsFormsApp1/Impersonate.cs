using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MESTools
{
    public static class ImpersonationUtil
    {
        public static bool Impersonate()
        {
            string logon = Properties.Settings.Default.AdminUser;
            string password = Properties.Settings.Default.AdminPassword;
            string domain = Properties.Settings.Default.AdminDomain;

            IntPtr token = IntPtr.Zero;
            IntPtr tokenDuplicate = IntPtr.Zero;
            WindowsImpersonationContext impersonationContext = null;

            if (LogonUser(logon, domain, password, 2, 0, ref token) != 0)
                if (DuplicateToken(token, 2, ref tokenDuplicate) != 0)
                    impersonationContext = new WindowsIdentity(tokenDuplicate).Impersonate();
            //

            return (impersonationContext != null);
        }

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern int LogonUser(string lpszUserName, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

        [DllImport("advapi32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
        public extern static int DuplicateToken(IntPtr hToken, int impersonationLevel, ref IntPtr hNewToken);
    }
}
