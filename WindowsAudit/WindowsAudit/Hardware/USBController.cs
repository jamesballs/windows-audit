using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAudit
{
    class USBController
    {
        Int16 Availability;
        string Caption;
        Int32 ConfigManagerErrorCode;
        bool ConfigManagerUserConfig;
        string CreationClassName;
        string Description;
        string DeviceID;
        bool ErrorCleared;
        string ErrorDescription;
        DateTime InstallDate;
        Int32 LastErrorCode;
        string Manufacturer;
        Int32 MaxNumberControlled;
        string Name;
        string PNPDeviceID;
        Int16[] PowerManagementCapabilities;
        bool PowerManagementSupported;
        Int16 ProtocolSupported;
        string Status;
        Int16 StatusInfo;
        string SystemCreationClassName;
        string SystemName;
        DateTime TimeOfLastReset;
    }
}
