using System;
using System.Runtime.InteropServices;

namespace BsodLib
{
    internal static class NT
    {
        /// <see cref="http://undocumented.ntinternals.net/index.html?page=UserMode%2FUndocumented%20Functions%2FError%2FNtRaiseHardError.html"/>
        internal const uint HARDWARE_RESPONSE_OPTION_SHUTDOWN_SYSTEM = 6;

        /// <see cref="https://docs.microsoft.com/en-us/windows/win32/secauthz/privilege-constants"/>
        internal const ulong PRIVILEGE_SE_SHUTDOWN_NAME = 19;

        /// <see cref="https://docs.microsoft.com/en-us/openspecs/windows_protocols/ms-erref/596a1078-e883-4972-9bbc-49e60bebca55"/>
        internal const ulong STATUS_ACCESS_DENIED = 0xc0000022;

        /// <see cref="https://source.winehq.org/WineAPI/RtlAdjustPrivilege.html"/>
        [DllImport("ntdll.dll")]
        internal static extern uint RtlAdjustPrivilege(ulong Privilege, bool Enable, bool CurrentThread, out bool Enabled);

        /// <see cref="http://undocumented.ntinternals.net/index.html?page=UserMode%2FUndocumented%20Functions%2FError%2FNtRaiseHardError.html"/>
        [DllImport("ntdll.dll")]
        internal static extern uint NtRaiseHardError(ulong ErrorStatus, ulong NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);
    }
}
