double[] doubleArray = new double[] { 2.4, 11, 12, 634, 0.99 };
// Reversing array
Array.Reverse(doubleArray);
Console.WriteLine(doubleArray);
// Finding something in an array
int indexFound = Array.IndexOf(doubleArray, 12);
Console.WriteLine(indexFound);
int indexNotFound = Array.IndexOf(doubleArray, 5.5);
Console.WriteLine(indexNotFound);

// Change an array number of items
Array.Resize(ref doubleArray, 6);
doubleArray[5] = 105.6;
Console.WriteLine(doubleArray[5]);
Console.ReadLine();