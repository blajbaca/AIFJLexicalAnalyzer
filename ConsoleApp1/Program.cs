using System.Data.Common;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> separators = new List<string>();
            List<string> keywords = new List<string>();
            List<string> operators = new List<string>();
           
            separators.Add(";");
            separators.Add(":");
            separators.Add(",");
            separators.Add("'");
            separators.Add("{");
            separators.Add("}");
            separators.Add("\"");
            separators.Add("„");
            separators.Add("(");
            separators.Add(")");
            separators.Add("“");

            operators.Add("+");
            operators.Add("-");
            operators.Add("*");
            operators.Add("/");
            operators.Add("<");
            operators.Add(">");
            operators.Add("=");
            operators.Add("[");
            operators.Add("]");

            keywords.Add("int");
            keywords.Add("char");
            keywords.Add("string");
            keywords.Add("if");
            keywords.Add("for");
            keywords.Add("return");
            keywords.Add("void");
            keywords.Add("else");

            string text = System.IO.File.ReadAllText(@"E:\Fakultet\Automati\LVX\test.txt");
            string[] words = text.Split(" ");

            int operatorCounter = 0;
            int keywordCounter=0;
            int separatorCounter = 0;
            int commentCounter = 0;
            int constantCounter = 0;
            int valueOrUnknownCounter = 0;


            foreach (string item in words)
            {
                if (item[0] == 37)
                {
                    Console.WriteLine($"{item} - comment");
                }
                else if (item[0] == 35)
                {
                    Console.WriteLine($"{item} - constant");
                }
                else if (operators.Contains(item))
                {
                    Console.WriteLine($"{item} - operator");
                }
                else if (keywords.Contains(item))
                {
                    Console.WriteLine($"{item} - keyword");
                }
                else if (separators.Contains(item))
                {
                    Console.WriteLine($"{item} - separators");
                }
                else
                {
                    Console.WriteLine($"{item} - value or unknown");
                }

            }
            foreach(string item in words)
            {
                if (item[0] == 37)
                {
                    commentCounter++;
                }
                if (item[0] == 35)
                {
                    constantCounter++;
                }
                if (operators.Contains(item))
                {
                    operatorCounter++;
                }
                else if (keywords.Contains(item))
                {
                    keywordCounter++;
                }
                else if (separators.Contains(item))
                {
                    separatorCounter++;
                }
                else
                {
                    valueOrUnknownCounter++;
                }
            }
            Console.WriteLine($"{operatorCounter} operators");
            Console.WriteLine($"{commentCounter} comments");
            Console.WriteLine($"{constantCounter} constants");
            Console.WriteLine($"{keywordCounter} keywords");
            Console.WriteLine($"{separatorCounter} separators");
            Console.WriteLine($"{valueOrUnknownCounter} valueorunknown");
            
        }

    }
}