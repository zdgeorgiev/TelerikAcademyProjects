bool isNumberFound = false;

for (i = 0; i < 100; i++) 
{
   	Console.WriteLine(array[i]);

   	if (array[i] == expectedValue) 
   	{
        isNumberFound = true;
        break;
   	}
}

// More code here
if (isNumberFound)
{
    Console.WriteLine("Value Found");
}
