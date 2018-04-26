using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAudit
{
    class SystemSlot
    {
        Int32 BusNumber;
        string Caption;
        string ConnectorPinout;
        Int16[] ConnectorType;
        string CreationClassName;
        Int16 CurrentUsage;
        string Description;
        Int32 DeviceNumber;
        Int32 FunctionNumber;
        float HeightAllowed;
        DateTime InstallDate;
        float LengthAllowed;
        string Manufacturer;
        Int16 MaxDataWidth;
        string Model;
        string Name;
        Int16 Number;
        string OtherIdentifyingInfo;
        string PartNumber;
        bool PMESignal;
        bool PoweredOn;
        string PurposeDescription;
        Int32 SegmentGroupNumber;
        string SerialNumber;
        bool Shared;
        string SKU;
        string SlotDesignation;
        bool SpecialPurpose;
        string Status;
        bool SupportsHotPlug;
        string Tag;
        Int32 ThermalRating;
        Int16[] VccMixedVoltageSupport;
        string Version;
        Int16[] VppMixedVoltageSupport;
    }
}
