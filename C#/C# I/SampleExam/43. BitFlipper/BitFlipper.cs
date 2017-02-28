using System;

class BitFlipper
{
    static void Main(string[] args)
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string bitRepresentation = Convert.ToString((long)number, 2);
        int bitLenght = bitRepresentation.Length;

        for (int i = 0; i < 64 - bitLenght; i++)
        {
            bitRepresentation = bitRepresentation.Insert(0, "0");
        }

        for (int i = 0; i < bitRepresentation.Length - 2; i++)
        {
            char currentBit = bitRepresentation[i];

            if (bitRepresentation[i + 1] == currentBit &&
                bitRepresentation[i + 2] == currentBit)
            {
                bitRepresentation = bitRepresentation.Remove(i, 3);

                char newBitValue = '1';

                if (currentBit == '1')
	            {
                    newBitValue = '0';
	            }

                for (int j = 0; j < 3; j++)
                {
                    bitRepresentation = bitRepresentation.Insert(i, newBitValue.ToString());
                }

                i += 2;
            }
        }

        Console.WriteLine(Convert.ToUInt64(bitRepresentation, 2));
    }
}