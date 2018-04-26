using System;
using System.Collections.Generic;
using System.Text;

namespace windows_audit
{
    class Process
    {
        string CreationClassName;
        string Caption;
        string CommandLine;
        DateTime CreationDate;
        string CSCreationClassName;
        string CSName;
        string Description;
        string ExecutablePath;
        Int16 ExecutionState;
        string Handle;
        Int32 HandleCount;
        DateTime InstallDate;
        Int64 KernelModeTime;
        Int32 MaximumWorkingSetSize;
        Int32 MinimumWorkingSetSize;
        string Name;
        string OSCreationClassName;
        string OSName;
        Int64 OtherOperationCount;
        Int64 OtherTransferCount;
        Int32 PageFaults;
        Int32 PageFileUsage;
        Int32 ParentProcessId;
        Int32 PeakPageFileUsage;
        Int64 PeakVirtualSize;
        Int32 PeakWorkingSetSize;
        Int32 Priority;
        Int64 PrivatePageCount;
        Int32 ProcessId;
        Int32 QuotaNonPagedPoolUsage;
        Int32 QuotaPagedPoolUsage;
        Int32 QuotaPeakNonPagedPoolUsage;
        Int32 QuotaPeakPagedPoolUsage;
        Int64 ReadOperationCount;
        Int64 ReadTransferCount;
        Int32 SessionId;
        string Status;
        DateTime TerminationDate;
        Int32 ThreadCount;
        Int64 UserModeTime;
        Int64 VirtualSize;
        string WindowsVersion;
        Int64 WorkingSetSize;
        Int64 WriteOperationCount;
        Int64 WriteTransferCount;
    }
}
