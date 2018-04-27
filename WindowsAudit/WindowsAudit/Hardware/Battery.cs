using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAudit
{
    class Battery
    {
        Int16 Availability;
        Int32 BatteryRechargeTime;
        Int16 BatteryStatus;
        string Caption;
        Int16 Chemistry;
        Int32 ConfigManagerErrorCode;
        bool ConfigManagerUserConfig;
        string CreationClassName;
        string Description;
        Int32 DesignCapacity;
        Int64 DesignVoltage;
        string DeviceID;
        bool ErrorCleared;
        string ErrorDescription;
        Int16 EstimatedChargeRemaining;
        Int32 EstimatedRunTime;
        Int32 ExpectedBatteryLife;
        Int32 ExpectedLife;
        Int32 FullChargeCapacity;
        DateTime InstallDate;
        Int32 LastErrorCode;
        Int32 MaxRechargeTime;
        string Name;
        string PNPDeviceID;
        Int16[] PowerManagementCapabilities;
        bool PowerManagementSupported;
        string SmartBatteryVersion;
        string Status;
        Int16 StatusInfo;
        string SystemCreationClassName;
        string SystemName;
        Int32 TimeOnBattery;
        Int32 TimeToFullCharge;
    }
}
