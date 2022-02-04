using System;
using System.Collections.Generic;

namespace Chapter2_Sorting
{
    class Program
    {
        static Random _Random = new Random();

        static void Main(string[] args)
        {
            /*
             * (정수) 배열 A 가 정렬되면 A 와 관련된 많은 문제 가 쉬워집니다.

               1.배열 A 에서 특정 값 v 검색 ,
               2.(정적) 배열 A 에서 최소/최대 또는 k번째 최소/최대 값 찾기 ,
               3.고유성 테스트 및 배열 A 에서 중복 삭제 ,
               4.특정 값 v 가 배열 A 에 나타나는 횟수를 세고 ,
               6.배열 A 와 다른 정렬된 배열 B 사이의 교집합/합집합을 설정합니다 .
               7.x+y 가 타겟 z 와 같 도록 타겟 쌍 x ∈ A 및 y ∈ A 찾기
               8.배열 A의 값 이 [ lo .. hi ] 범위 내에 있는지 계산하는 등
               9.토론: 실제 수업에서 강사는 이러한 응용 프로그램에 대해 더 자세히 설명할 수 있습니다.
             * 
             * 
             */

            // 1.배열 A 에서 특정 값 v 검색
            List<int> Int = new List<int>() { 100,700,32,84,774 };
            string s_Data = "Hello";
            string s_Input = "2222";

            Console.WriteLine(IsFindValue(s_Data, s_Input));
           

            

            Console.ReadKey();
        }

        //1. 배열 A 에서 특정 값 v 검색

        static bool IsFindValue(List<int> Int, int v) // 성공
        {
            bool IsFindResult = false;

            for (int i = 0; i < Int.Count; i++)
            {
                if (Int[i] == v)
                {
                    IsFindResult = true;
                }
            }

            return IsFindResult;
        }

        static bool IsFindValue(string Input, string Pattern)
        {
            bool IsFindResult = false;

            for (int i = 0; i< Input.Length;i++)
            {
                for (int j = 0; j < Pattern.Length; j++)
                {
                    if (Input[i] == Pattern[j])
                    {
                        IsFindResult = true;
                    }
                    else
                    {
                        IsFindResult = false;
                    }
                }
            }

            return IsFindResult;
        }
 

        static int FindMaxValue(List<int> Int) 
        {
            int MaxMinValue = 0;
            int MaxValue = 0;
            int Index = 0;
            int X = 0;

            for (int i =0;i< Int.Count;i++)
            {
                if (Int[i] < MaxValue)
                {
                    MaxValue = Int[i];
                    Index = X;
                }
                X++;
            }

            MaxMinValue = X;
            
            return MaxMinValue;
        }

        static int FindMinValue(List<int> Int)
        {
            int MinValue = Int[0];

            for (int i = 0; i< Int.Count;i++)
            {
                if (MinValue > Int[i])
                {
                    MinValue = Int[i];
                }
            }

            return MinValue;
        }
    }
}
