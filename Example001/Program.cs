using System.Linq;

/*
int a = 12;
Console.WriteLine(a.GetType()); // System.Int32

int b = 12;
Console.WriteLine(b.GetType().Name); // Int32

var c = 12;
Console.WriteLine(c.GetType()); // System.Int32
*/

var data = new int[] { 1, 2, 3, 4 }
        .Where(e => e > 0)
        .Select(e => new { q = e, w = e + 1 });
Console.WriteLine(data.GetType());