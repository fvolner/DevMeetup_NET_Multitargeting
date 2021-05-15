using System.Text;
using System.Web.Security;

namespace Protection
{
    class ProtectionService
    {
        public byte[] ProtectMyAuth(string unprotectedValue)
        {
            var encodedToken = Encoding.ASCII.GetBytes(unprotectedValue);

            return MachineKey.Protect(encodedToken, "MyAuth");
        }
    }
}
