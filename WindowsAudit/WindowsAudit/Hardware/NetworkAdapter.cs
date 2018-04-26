using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAudit
{
    class NetworkAdapter
    {
        string AdapterType;
        Int16 AdapterTypeID;
        bool AutoSense;
        Int16 Availability;
        string Caption;
        Int32 ConfigManagerErrorCode;
        bool ConfigManagerUserConfig;
        string CreationClassName;
        string Description;
        string DeviceID;
        bool ErrorCleared;
        string ErrorDescription;
        string GUID;
        Int32 Index;
        DateTime InstallDate;
        bool Installed;
        Int32 InterfaceIndex;
        Int32 LastErrorCode;
        string MACAddress;
        string Manufacturer;
        Int32 MaxNumberControlled;
        Int64 MaxSpeed;
        string Name;
        string NetConnectionID;
        Int16 NetConnectionStatus;
        bool NetEnabled;
        string[] NetworkAddresses;
        string PermanentAddress;
        bool PhysicalAdapter;
        string PNPDeviceID;
        Int16[] PowerManagementCapabilities;
        bool PowerManagementSupported;
        string ProductName;
        string ServiceName;
        Int64 Speed;
        string Status;
        Int16 StatusInfo;
        string SystemCreationClassName;
        string SystemName;
        DateTime TimeOfLastReset;
    }
}
