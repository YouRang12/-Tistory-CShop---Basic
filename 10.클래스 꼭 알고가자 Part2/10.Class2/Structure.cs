using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _10.Class2
//{
//    struct Point3D
//    {
//        public int X;
//        public int Y;
//        public int Z;

//        public Point3D(int X, int Y, int Z)
//        {
//            this.X = X;
//            this.Y = Y;
//            this.Z = Z;
//        }

//        // System.Object 형식의 ToString() 메소드를 오버라이딩
//        public override string ToString()
//        {
//            return string.Format($"{X}, {Y}, {Z}");

//        }
//    }

//    class Structure
//    {
//        static void Main(string[] args)
//        {
//            // 선언만으로 인스턴스가 생성
//            Point3D p3d1;
//            p3d1.X = 10;
//            p3d1.Y = 20;
//            p3d1.Z = 40;

//            Console.WriteLine(p3d1.ToString());

//            // 생성자를 이용한 인스턴스 생성도 가능
//            Point3D p3d2 = new Point3D(100, 200, 300);
//            // 구조체의 인스턴스를 다른 인스턴스에 할당하면 깊은 복사가 이루어짐
//            Point3D p3d3 = p3d2;
//            p3d3.Z = 400;

//            Console.WriteLine(p3d2.ToString());
//            Console.WriteLine(p3d3.ToString());
//        }
//    }
//}
