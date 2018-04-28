# windows-audit
Library to easily and quickly get information about both the hardware and software of a Windows machine. Written in C# for .NET applications.

# MOVING TO SimpleWMI INSTEAD
I am stopping development of this repositry to opt into a more abstract model for all WMI classes that doesn't require class reimplementation in C#. This should help all WMI classes to work without much overhead on my end.

Instead of just focusing on auditing Windows machines, this should be more general and focuses on any sort of data extraction from WMI classes.
