using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace _09.Class
//{
//    class WaterHeater
//    {
//        protected int temperature;

//        // - 5 ~ 42 사이의 값만 받아들이고, 
//        // 범위를 벗어난 값에 대해서는 예외를 발생시킨다.
//        public void SetTemperature(int temperature)
//        {
//            if (temperature < -5 || temperature > 42)
//            {
//                // 예외 발생
//                throw new Exception("Out of temperature range");
//            }
//            // protected는 외부에서 접근X
//            this.temperature = temperature;
//        }

//        internal void TurnOnWater()
//        {
//            Console.WriteLine($"Turn on water : {temperature}");
//        }
//    }

//    class AccessModifier
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                WaterHeater heater = new WaterHeater();
//                heater.SetTemperature(20);
//                heater.TurnOnWater();

//                heater.SetTemperature(-2);
//                heater.TurnOnWater();

//                // 예외가 발생하면 catch로 넘어감
//                heater.SetTemperature(50);
//                heater.TurnOnWater();
//            }
//            catch(Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}
