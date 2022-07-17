using Day8LineComparisionOops;


Line line = new Line();
double result1 = line.Length();
Console.WriteLine("Length Of Line1: {0}", result1);
double result2 = line.Length();
Console.WriteLine("Length Of Line2: {0}", result2);

if (result1 == result2)
    Console.WriteLine("Length1 and length2  Are Equal");
else
    Console.WriteLine("Length1 and length2  Are not Equal");

