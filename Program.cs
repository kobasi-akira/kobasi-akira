using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //GitHubにテストで送るやつ
            int m_Test_A;
            int m_Test_B;

            Console.WriteLine("2つの入力した数値を足し算します。");

            Console.Write("一つ目の数値を入力してください : ");
            m_Test_A = int.Parse(Console.ReadLine());

            Console.Write("二つ目の数値を入力してください : ");
            m_Test_B = int.Parse(Console.ReadLine());

            Console.WriteLine("合計 : {0}", m_Test_A + m_Test_B);
        }
    }
}
