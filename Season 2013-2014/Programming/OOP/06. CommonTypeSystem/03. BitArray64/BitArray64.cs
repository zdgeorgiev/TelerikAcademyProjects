using System;
using System.Collections;
using System.Collections.Generic;

class BitArray64 : IEnumerable<int>
{
    public ulong Number { get; private set; }

    public BitArray64(ulong number)
    {
        this.Number = number;
    }

    public int this[int index]
    {
        get
        {
            if (index > 64 || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid Range");
            }

            int decimalNumber = (int)this.Number;
            int remainder;
            string result = string.Empty;

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder + result;
            }

            return Convert.ToInt32((((ulong)1 << index) & this.Number) >> index);
        }
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 64; i++)
        {
            yield return i;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public override bool Equals(object obj)
    {
        var other = obj as BitArray64;

        if (other == null)
        {
            return false;
        }

        if (!Object.Equals(this, other))
        {
            return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        return this.Number.GetHashCode();
    }

    public static bool operator ==(BitArray64 first, BitArray64 second)
    {
        return BitArray.Equals(first, second);
    }

    public static bool operator !=(BitArray64 first, BitArray64 second)
    {
        return !BitArray.Equals(first, second);
    }
}