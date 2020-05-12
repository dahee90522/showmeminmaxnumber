using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min, i;
            String n;
            int[] num = new int[5];

            Console.Write("숫자를 입력해주세요 : ");
            n=Console.ReadLine();  //입력받기
            num[0] = Convert.ToInt32(n);//int로 바꾸기, 배열에 값 넣기
            max = num[0]; //num[0] 의 값을 시작으로 최대,최소값을 구함.
            min = num[0];

            for (i = 1; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요 : ");
                n = Console.ReadLine(); 
                num[i] = Convert.ToInt32(n);
                if (max < num[i])
                { //만약 max가 num[i]보다 작으면 max는num[i]의 값이 된다.
                    max = num[i];
                }
                if (min > num[i])
                { //생략
                    min = num[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------\n"); 
            Console.WriteLine("가장 큰 수 : "+ max); //최대값과 최소값의 결과를 출력
            Console.WriteLine("가장 작은 수 : "+ min);
        }
    }
}
