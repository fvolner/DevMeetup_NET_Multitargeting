namespace Protection
{
    public class ProtectionManager
    {
#if NETFRAMEWORK
        public static byte[] ProtectMyAuth(string unprotectedValue)
        {
            return new ProtectionService().ProtectMyAuth(unprotectedValue);
        }
#endif
#if NETSTANDARD
        public static byte[] ProtectMyAuth(string unprotectedValue, Microsoft.AspNetCore.DataProtection.IDataProtectionProvider dataProtectionProvider)
        {
            return new ProtectionService(dataProtectionProvider).ProtectMyAuth(unprotectedValue);
        } 
#endif
    }
}
