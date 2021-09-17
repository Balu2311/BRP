using System;

/*WAP to get the index of all the characters of the alphabet.
Sample string of all alphabet: "The quick brown fox jumps over the lazy dog."
Sample Output:
a    b  c  d  e   f   g  h  i   j                                                                                     
=========================                                                                                     
36 10 7 40 2 16 42 1 6 20                                                   
k   l    m  n  o    p  q  r   s   t                                                                                   
===========================                                                                                   
8 35 22 14 12 23 4 11 24 31                                                                                   
u  v   w   x   y   z                                                                                              
================  
5 27 13 18 38 37  */
namespace String_alp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string of all alphabet");
            String str = "The quick brown fox jumps over the lazy dog.";

            // Get the index of all the characters of the alphabet
            // starting from the beginning of the String.
            int a = str.IndexOf("a", 0);
            int b = str.IndexOf("b", 0);
            int c = str.IndexOf("c", 0);
            int d = str.IndexOf("d", 0);
            int e = str.IndexOf("e", 0);
            int f = str.IndexOf("f", 0);
            int g = str.IndexOf("g", 0);
            int h = str.IndexOf("h", 0);
            int i = str.IndexOf("i", 0);
            int j = str.IndexOf("j", 0);
            int k = str.IndexOf("k", 0);
            int l = str.IndexOf("l", 0);
            int m = str.IndexOf("m", 0);
            int n = str.IndexOf("n", 0);
            int o = str.IndexOf("o", 0);
            int p = str.IndexOf("p", 0);
            int q = str.IndexOf("q", 0);
            int r = str.IndexOf("r", 0);
            int s = str.IndexOf("s", 0);
            int t = str.IndexOf("t", 0);
            int u = str.IndexOf("u", 0);
            int v = str.IndexOf("v", 0);
            int w = str.IndexOf("w", 0);
            int x = str.IndexOf("x", 0);
            int y = str.IndexOf("y", 0);
            int z = str.IndexOf("z", 0);

            // Display the results of all the indexOf method calls.
            Console.WriteLine(" a  b c  d e  f  g h i  j");
            Console.WriteLine("=========================");
            Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e + " " + f + " " + g + " " + h + " " + i + " " + j + "\n");

            Console.WriteLine("k  l  m  n  o  p q  r  s  t");
            Console.WriteLine("===========================");
            Console.WriteLine(k + " " + l + " " + m + " " + n + " " + o + " " + p + " " + q + " " + r + " " + s + " " + t + "\n");

            Console.WriteLine("u  v  w  x  y  z");
            Console.WriteLine("================");
            Console.WriteLine(u + " " + v + " " + w + " " + x + " " + y + " " + z);
        }
    }
}
