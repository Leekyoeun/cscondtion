﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace cscondtion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 입력:");
            var input = int.Parse(Console.ReadLine());
            /*if (input % 2 == 0)
            {
                Console.WriteLine("짝수 입니다");
            }
            if (input % 2 == 1)
            {
                Console.WriteLine("홀수 입니다");
            }*/
            Console.WriteLine(input>0? "자연수입니다":"자연수가 아닙니다");
            Console.WriteLine(input%2==0 ? "짝수입니다" : "홀수입니다");

            //현재 시간 구하기
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            //오전과 오후 구분
            if (DateTime.Now.Hour <12 )
            {
                Console.Write("오전입니다");
            }
            if (DateTime.Now.Hour >=12)
            {
                Console.Write("오후입니다");
            }
            else
            {
                Console.Write("저녁먹을 시간입니다");
            }
            Console.WriteLine("이번 달은 몇 월인가요?");
            int input2 = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다");
                    break;
                default:
                    Console.WriteLine("대체 어디에?");
            }
            Console.Write("입력: ");
            String line = Console.ReadLine();
            if (line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요");
            }
            else
            {
                Console.WriteLine("인사 안해요?");
            }
            ConsoleKeyInfo info= Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로이동");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로 이동");
                    break;
                case ConsoleKey RightArrow:
                    Console.WriteLine("오른쪽 이동");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽 이동");
                    break;

                default:
                    Console.Write("다른 키를 눌렀습니다");
                    break;
            }
            switch (info.KeyChar)
            {
                case (char)38:
                    Console.WriteLine("위로 이동");
                    break;
            }
        }
      
    }
}
