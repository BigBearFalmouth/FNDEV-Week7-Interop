using System;

using System.Runtime.InteropServices;

namespace MessageBeepDemo
{
    class WindowsAPIWrapper
    {
        public const UInt32 MB_OK = 0x00000000;
        public const UInt32 MB_ICONHAND = 0x00000010;
        public const UInt32 MB_ICONQUESTION = 0x00000020;
        public const UInt32 MB_ICONEXCLAMATION = 0x00000030;
        public const UInt32 MB_ICONASTERISK = 0x00000040;

        [DllImport("User32.dll",SetLastError=true)]
        public static extern Int32 MessageBeep([In]UInt32 uType);

        public enum POWER_INFORMATION_LEVEL:byte
        {
            LastSleepTime=15,
        }

  //      NTSTATUS WINAPI CallNtPowerInformation(
  //_In_   POWER_INFORMATION_LEVEL InformationLevel,
  //_In_   PVOID lpInputBuffer,
  //_In_   ULONG nInputBufferSize,
  //_Out_  PVOID lpOutputBuffer,
  //_In_   ULONG nOutputBufferSize
//);
        public static extern Int32 CallNTPowerStatus([In]POWER_INFORMATION_LEVEL infoLvl,
            IntPtr InputBuffer, UInt64 bufferSize, out IntPtr outputBuffer, UInt64 outputBufferSize);
    }

    // MessageBeep Windows API function in User32.dll is defined in Platform SDK docs as:
    // BOOL WINAPI MessageBeep(
    //   _in UINT uType
    // );
}
