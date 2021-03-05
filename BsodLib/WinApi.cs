using System;

namespace BsodLib
{
    public static class WinApi
    {
        /// <summary>
        /// Trigger a "Blue Screen Of Death" (BSOD)
        /// </summary>
        public static void TriggerBSOD()
        {
            bool bool_0;
            uint uint_0;

            // enable shutdown privilege
            _ = NT.RtlAdjustPrivilege(NT.PRIVILEGE_SE_SHUTDOWN_NAME, true, false, out bool_0);

            // trigger bsod
            _ = NT.NtRaiseHardError(NT.STATUS_ACCESS_DENIED, 0, 0, IntPtr.Zero, NT.HARDWARE_RESPONSE_OPTION_SHUTDOWN_SYSTEM, out uint_0);
        }
    }
}
