using System.Text;
using System.Web.Security;

namespace Protection
{
    public class ProtectionManager
    {
        public static byte[] ProtectMyAuth(string unprotectedValue)
        {
            var encodedToken = Encoding.ASCII.GetBytes(unprotectedValue);

            return MachineKey.Protect(encodedToken, "MyAuth");
        }
    }
}
