using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _10.Class2
//{
//    class Configuration
//    {
//        List<ItemValue> listConfig = new List<ItemValue>();

//        public void SetConfig(string item, string value)
//        {
//            ItemValue iv = new ItemValue();
//            iv.SetValue(this, item, value);
//        }

//        public string GetConfig(string item)
//        {
//            foreach(ItemValue iv in listConfig)
//            {
//                if (iv.GetItem() == item)
//                    return iv.GetValue();
//            }

//            return "";
//        }
//        // 중첩 클래스
//        // 1) 클래스를 외부에 공개하고 싶지 않을 때 사용
//        // 2) 현재의 클래스의 일부분처럼 표현하고 싶을 때 사용
//        private class ItemValue
//        {
//            private string item;
//            private string value;

//            public void SetValue(Configuration config, string item, string value)
//            {
//                this.item = item;
//                this.value = value;

//                bool found = false;
//                for (int i = 0; i < config.listConfig.Count; i++)
//                {
//                    if (config.listConfig[i].item == item)
//                    {
//                        config.listConfig[i] = this;
//                        found = true;
//                        break;
//                    }
//                }
//                if (found == false)
//                    config.listConfig.Add(this);
//            }

//            public string GetItem()
//            {
//                return item;
//            }
//            public string GetValue()
//            {
//                return value;
//            }
//        }
//    }

//    class NestedClass
//    {
//        static void Main(string[] args)
//        {
//            Configuration config = new Configuration();
//            config.SetConfig("Version", "V 5.0");
//            config.SetConfig("Size", "655,324 KB");

//            Console.WriteLine(config.GetConfig("Version"));
//            Console.WriteLine(config.GetConfig("Size"));

//            config.SetConfig("Version", "V 5.0.1");
//            Console.WriteLine(config.GetConfig("Version"));
//        }
//    }
//}
