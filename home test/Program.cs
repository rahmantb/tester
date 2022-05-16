using System;

namespace home_test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int a = 100;
              byte byt = 32;
              int b = byt;
              byte by = (byte)a;
              float fl = 25.25f;
              double dbl = 2525.26;
              double db =(float)dbl;
            */
            #region dersler,numuneler:
            /* int defaultval = default(int);
             string stringval = default(string);
             bool boolval = default(bool);
             DateTime datetimevalu = default(DateTime);
             Console.WriteLine(datetimevalu);
             Console.WriteLine(stringval);
             Console.WriteLine(boolval);
             Console.WriteLine(defaultval);
            */
            #endregion
            /*  string name = "Elnur Qurbanov";
              int namelenght = name.Length;
              Console.WriteLine(namelenght);
              bool hasR = name.Contains("r");
              bool isstarwithQ = name.StartsWith("Q");
               string sub = name.Substring(3);
              Console.WriteLine(sub);
              Console.WriteLine(name);
              // Console.WriteLine(isstarwithQ);
              //Console.WriteLine(hasR);
              int indexofl=name.IndexOf("r");
              Console.WriteLine(indexofl);
             int lastindexofh= name.LastIndexOf("r");
              Console.WriteLine(lastindexofh);
              string lowname=name.ToLower();
             string testinsert= name.Insert(4, "test");
              Console.WriteLine(testinsert);
              string rep=name.Replace('a', 'b');
              Console.WriteLine(rep);
            */
            /* char cg = 'A';
             char cf = 'B';
             var val1 = cg.ToString()+cf.ToString();
             Console.WriteLine(val1);
             bool boleannn = (5 > 6) && (6 > 7);
             Console.WriteLine(boleannn);
            */
            /*int defoutvalue = default(int);
            Console.WriteLine(defoutvalue);
            bool defbool = default(bool);
            Console.WriteLine(defbool);
            */
            var isitok = byte.TryParse(Console.ReadLine(), out byte result);
            Console.WriteLine(isitok);
        }
    }
}
