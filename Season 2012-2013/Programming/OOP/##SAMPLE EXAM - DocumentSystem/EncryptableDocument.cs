﻿using System;
using System.Collections.Generic;

public class EncryptableDocument : BinaryDocument, IEncryptable
{
    public bool IsEncrypted { get; private set; }

    public void Encrypt()
    {
        this.IsEncrypted = true;
    }

    public void Decrypt()
    {
        this.IsEncrypted = false;
    }

    public override string ToString()
    {
        if (this.IsEncrypted)
        {
            return string.Format(this.GetType().Name + "[encrypted]");
        }
        else
        {
            return base.ToString();
        }
    }
}
