﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAudit
{
    class CacheMemory
    {
        Int16 Access;
        Int16[] AdditionalErrorData;
        Int16 Associativity;
        Int16 Availability;
        Int64 BlockSize;
        Int32 CacheSpeed;
        Int16 CacheType;
        string Caption;
        Int32 ConfigManagerErrorCode;
        bool ConfigManagerUserConfig;
        bool CorrectableError;
        string CreationClassName;
        Int16[] CurrentSRAM;
        string Description;
        string DeviceID;
        Int64 EndingAddress;
        Int16 ErrorAccess;
        Int64 ErrorAddress;
        bool ErrorCleared;
        Int16 ErrorCorrectType;
        Int16[] ErrorData;
        Int16 ErrorDataOrder;
        string ErrorDescription;
        Int16 ErrorInfo;
        string ErrorMethodology;
        Int64 ErrorResolution;
        DateTime ErrorTime;
        Int32 ErrorTransferSize;
        Int32 FlushTimer;
        DateTime InstallDate;
        Int32 InstalledSize;
        Int32 LastErrorCode;
        Int16 Level;
        Int32 LineSize;
        Int16 Location;
        Int32 MaxCacheSize;
        string Name;
        Int64 NumberOfBlocks;
        string OtherErrorDescription;
        string PNPDeviceID;
        Int16[] PowerManagementCapabilities;
        bool PowerManagementSupported;
        string Purpose;
        Int16 ReadPolicy;
        Int16 ReplacementPolicy;
        Int64 StartingAddress;
        string Status;
        Int16 StatusInfo;
        Int16[] SupportedSRAM;
        string SystemCreationClassName;
        bool SystemLevelAddress;
        string SystemName;
        Int16 WritePolicy;
    }
}