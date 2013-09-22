﻿using System;

public class VersionAttribute : System.Attribute
{
    public int Major { get; set; }
    public int Minor { get; set; }

    public VersionAttribute(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
    }

    public override string ToString()
    {
        return string.Format("{0},{1}", this.Major, this.Minor);
    }
}