using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Property
{
    // 추상 클래스
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }
        // 추상 프로퍼티
        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get;
            set;
        }
    }

    class PropertiesInAbstractClass
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            { ProductDate = new DateTime(2018, 1, 10)};

            Console.WriteLine("Product:{0}, Product Date :{1}",
                product_1.SerialID,
                product_1.ProductDate);

            Product product_2 = new MyProduct()
            { ProductDate = new DateTime(2018, 2, 10) };

            Console.WriteLine("Product:{0}, Product Date :{1}",
                product_2.SerialID,
                product_2.ProductDate);
        }
    }
}
