using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BasicCodingSkills
{
    class Program
    {
        static void Main(string[] args)
        {
            // FindDuplicateWords();
            // WordReverse();
            //StringReverse();
            //Palindrome();
            //string m = RecursiveString("Ashw");
            //Console.WriteLine("Reversed string using recursion "+m);
            DAArrays array = new DAArrays();
            array.ArrayRotation();
            //Date--15/01/2021
            //string phoneNumber = CreatePhoneNumber(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            //Date--18/01/2021
            //SumOfNaturalNumber(20);
            Console.ReadLine();
        }
        public static void SumOfNaturalNumber(int nNumbers)
        {
           
                if (nNumbers == 0)
                {
                    Console.WriteLine("Number {0} is not a natural number", nNumbers);

                }
                else if (nNumbers < 0)
                {
                    Console.WriteLine("Number {0} is not a natural number", nNumbers);
                    Console.WriteLine("The sum of natural numbers {0} is {1}", nNumbers,0);
                }
                else
                 {
                    int sum = 0;
                    for (int i = 1; i < nNumbers; i++)
                    {
                        if ((i % 3==0) || (i % 5==0))
                        {
                            sum += i;
                        }
                    }
                Console.WriteLine("The sum of natural numbers {0} is {1}", nNumbers,sum);
         
                }
            

           int sumNum = Enumerable.Range(1, nNumbers-1).Where(x => x % 3 == 0
                                                 || x % 5 == 0).Sum();
            Console.WriteLine("The sum of natural numbers {0} is {1}", nNumbers, sumNum);
          
            int sumNum1 = Enumerable.Range(1, nNumbers-1).Sum(x => x % 3 == 0
                                                || x % 5 == 0 ? x : 0);
            Console.WriteLine("The sum of natural numbers {0} is {1}", nNumbers, sumNum1);
        }
            public static string CreatePhoneNumber(int[] numbers)
        {
    
            int[] temp = numbers;
            string newPhonenumber = "(";
            for (int i = 0; i < temp.Length/3; i++)
                        newPhonenumber += temp[i];
            newPhonenumber += ") ";
            for (int i = temp.Length / 3; i < 2*temp.Length / 3; i++)
                newPhonenumber += temp[i];
            newPhonenumber += "-";
            for (int i = 2 * temp.Length / 3; i < temp.Length; i++)
                newPhonenumber += temp[i];
         
            Console.WriteLine(newPhonenumber);

            //second method
            string np1 = string.Join("", numbers);
            string newPhonenumber1 = Regex.Replace(np1, @"(\d{3})(\d{3})(\d{4})", "($1) $2-$3");


            //Third method
         
            string newPhonenumber2 = string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers.Select(x=>x.ToString()).ToArray());

            return newPhonenumber;
        }

        public static void FindDuplicateWords()
        {
            string oString = "I I I am am owl";
            string[] nString = oString.Split(',', '.', '!', '?', ';', ':', ' ');
            
            Dictionary<string,int> d = new Dictionary<string, int>();
            for (int i=0;i< nString.Length;i++)
            {
                if (d.ContainsKey(nString[i]))
                {
                    d[nString[i]] = d[nString[i]] + 1;
                }
                else
                    d.Add(nString[i], 1);
            }
            if(nString.Length!=d.Count)
                Console.WriteLine("Duplicate words exists.");

            var o= d.Keys.ToArray();
            for(int x=0;x<d.Count;x++)
            {
               string strkey = o[x];
                if(d[strkey]>1)
                    Console.WriteLine("Word '" + strkey + "' repeated " + d[strkey] + " times");
            }
        }
        public static void Palindrome()
        {
            string oString = "hannah";//civic"


            string reverseString = null;

            for (int i = oString.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + oString[i];
            }

            if (reverseString.Equals(oString))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
           
            Console.ReadLine();
        }
        public static void WordReverse()
        {

           string oString = "My,Name is! Ashwini";
           string[] nString =oString.Split(',', '.', '!', '?', ';', ':', ' ');
            string reverseString = null;
            
            for (int i= nString.Length - 1; i>=0;i--)
            {
                reverseString = reverseString + " " + nString[i];
            }
            Console.WriteLine(reverseString);
            Console.ReadLine();
        }

        public static void StringReverse()
        {

            string oString = "Ashwini";
            //string[] nString = oString.Split(' ');
            string reverseString = null;
           
            for (int i = oString.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + oString[i];
            }
            Console.WriteLine(reverseString);
            Console.ReadLine();
        }

        public static string RecursiveString(string x)
        {
            if (x.Length > 0)
                return x[x.Length - 1] + RecursiveString(x.Substring(0, x.Length - 1));
            else
                return x;
        }
        public static int RecursiveFunction(int x, int y)
        {
           
            return 1;
        }
    }
}
