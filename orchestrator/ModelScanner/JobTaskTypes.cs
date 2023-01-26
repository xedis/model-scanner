﻿namespace ModelScanner;

[Flags]
public enum JobTaskTypes
{
    Import = 1,
    Convert = 2,
    Scan = 4,
    Hash = 8,
    Default = Import | Hash | Scan,
    All = Import | Convert | Scan | Hash
}