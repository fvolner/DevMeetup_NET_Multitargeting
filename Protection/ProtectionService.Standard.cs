using Microsoft.AspNetCore.DataProtection;

using System.Text;

namespace Protection
{
    class ProtectionService
    {
        private readonly IDataProtectionProvider dataProtectionProvider;

        public ProtectionService(IDataProtectionProvider dataProtectionProvider)
        {
            this.dataProtectionProvider = dataProtectionProvider;
        }

        public byte[] ProtectMyAuth(string unprotectedValue)
        {
            var encodedToken = Encoding.ASCII.GetBytes(unprotectedValue);

            var protector = dataProtectionProvider.CreateProtector("MyAuth");

            return protector.Protect(encodedToken);
        }
    }
}
