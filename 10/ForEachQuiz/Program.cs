using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // <1> 정수 변수 선언
        int count;

        // <2> 고객 리스트 생성 및 초기화
        List<string> customers = new List<string>() { "Pope", "Bob", "Ruin", "Rich", "John", "Doe", "Riven", "Pope" };

        // 고객 이름 추가
        customers.Add("Pope");
        customers.Add("Bob");
        customers.Add("Riven");
        customers.Add("Ruin");
        customers.Add("John");

        // <3> 중복 제거를 위한 HashSet 선언
        HashSet<string> filteredCustomers = new HashSet<string>();

        // <4><5> 고객 리스트 순회하며 HashSet에 추가
        foreach (string customer in customers)
        {
            filteredCustomers.Add(customer);
        }

        // 고유 고객 수 계산
        count = filteredCustomers.Count;

        // 출력
        Console.WriteLine(count);
    }
}