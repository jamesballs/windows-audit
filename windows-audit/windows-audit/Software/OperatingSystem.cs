﻿using System;
using System.Collections.Generic;
using System.Text;

namespace windows_audit
{
    class OperatingSystem
    {
        string BootDevice;
        string BuildNumber;
        string BuildType;
        string Caption;
        string CodeSet;
        string CountryCode;
        string CreationClassName;
        string CSCreationClassName;
        string CSDVersion;
        string CSName;
        Int16 CurrentTimeZone;
        bool DataExecutionPrevention_Available;
        bool DataExecutionPrevention_32BitApplications;
        bool DataExecutionPrevention_Drivers;
        Int16 DataExecutionPrevention_SupportPolicy;
        bool Debug;
        string Description;
        bool Distributed;
        Int32 EncryptionLevel;
        Int16 ForegroundApplicationBoost = 2;
        Int64 FreePhysicalMemory;
        Int64 FreeSpaceInPagingFiles;
        Int64 FreeVirtualMemory;
        DateTime InstallDate;
        Int32 LargeSystemCache;
        DateTime LastBootUpTime;
        DateTime LocalDateTime;
        string Locale;
        string Manufacturer;
        Int32 MaxNumberOfProcesses;
        Int64 MaxProcessMemorySize;
        string[] MUILanguages;
        string Name;
        Int32 NumberOfLicensedUsers;
        Int32 NumberOfProcesses;
        Int32 NumberOfUsers;
        Int32 OperatingSystemSKU;
        string Organization;
        string OSArchitecture;
        Int32 OSLanguage;
        Int32 OSProductSuite;
        Int16 OSType;
        string OtherTypeDescription;
        bool PAEEnabled;
        string PlusProductID;
        string PlusVersionNumber;
        bool PortableOperatingSystem;
        bool Primary;
        Int32 ProductType;
        string RegisteredUser;
        string SerialNumber;
        Int16 ServicePackMajorVersion;
        Int16 ServicePackMinorVersion;
        Int64 SizeStoredInPagingFiles;
        string Status;
        Int32 SuiteMask;
        string SystemDevice;
        string SystemDirectory;
        string SystemDrive;
        Int64 TotalSwapSpaceSize;
        Int64 TotalVirtualMemorySize;
        Int64 TotalVisibleMemorySize;
        string Version;
        string WindowsDirectory;
        Int16 QuantumLength;
        Int16 QuantumType;
    }
}