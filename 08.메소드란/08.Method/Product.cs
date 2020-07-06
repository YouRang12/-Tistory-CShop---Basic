using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Method
{
    //class Product
    //{
    //    private int price = 100;

    //    // 참조형 메소드, 참조값 반환
    //    public ref int GetPrice()
    //    {
    //        return ref price;
    //    }

    //    public void PrintPrice()
    //    {
    //        Console.WriteLine($"Price : {price}");
    //    }
    //}

    //class RefReturn
    //{
    //    static void Main(string[] args)
    //    {
    //        // 객체 생성
    //        Product carrot = new Product();

    //        // 참조 지역변수 선언
    //        // ref_local_price를 수정하면 
    //        // carrot.price의 내용도 바뀜
    //        ref int ref_local_price = ref carrot.GetPrice();

    //        // 지역변수 선언
    //        // normal_local_price를 수정하여도 
    //        // carrot.price의 내용은 바뀌지 않음
    //        int normal_local_price = carrot.GetPrice();

    //        // price값 출력
    //        carrot.PrintPrice();
    //        Console.WriteLine($"Ref Local Price : {ref_local_price}");
    //        Console.WriteLine($"Normal Local Price :{normal_local_price}");
    //        Console.WriteLine("*******************************참조값 변경 후");

    //        // 참조 지역변수 값 변경
    //        ref_local_price = 200;

    //        // price값 출력
    //        carrot.PrintPrice();
    //        Console.WriteLine($"Local Price : {ref_local_price}");
    //        Console.WriteLine($"Normal Local Price : {normal_local_price}");
    //    }
    //}
}
