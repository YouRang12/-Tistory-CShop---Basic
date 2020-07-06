using System;
using System.Reflection;
using System.Reflection.Emit;

// 리플렉션 => 객체의 형식(Type) 정보를 들여다보는 기능
//namespace _20.ReflectionAndAttribute
//{
//    public class EmitTest
//    {
//        // 형식 내보내기
//        public static void Main()
//        {
//            // AssemblyBuilder => 동적 어셈블리를 정의하고 나타냄
//            AssemblyBuilder newAssembly =
//                AppDomain.CurrentDomain.DefineDynamicAssembly(
//                    new AssemblyName("CalculatorAssembly"),
//                    AssemblyBuilderAccess.Run);
            
//            // ModuleBuilder => 동적 어셈블리 내의 모듈을 정의하고 나타냄
//            ModuleBuilder newModule = newAssembly.DefineDynamicModule(
//                                        "Calculator");

//            // TypeBuilder => 실행 중에 클래스를 정의하고 생성
//            TypeBuilder newType = newModule.DefineType("Sum1To100");

//            // MethodBuilder => 동적으로 만든 클래스의 메소드를 정의하고 나타냄
//            MethodBuilder newMethod = newType.DefineMethod(
//                "Calculate",
//                MethodAttributes.Public,
//                typeof(int),    // 반환 형식
//                new Type[0]);    // 매개 변수

//            // ILGenerator => MSIL 명령어를 생성함
//            ILGenerator generator = newMethod.GetILGenerator();

//            generator.Emit(OpCodes.Ldc_I4, 1);

//            for (int i = 2; i <= 100; i++)
//            {
//                generator.Emit(OpCodes.Ldc_I4, i);
//                generator.Emit(OpCodes.Add);
//            }

//            generator.Emit(OpCodes.Ret);
//            newType.CreateType();

//            object sum1To100 = Activator.CreateInstance(newType);
//            MethodInfo Calculate = sum1To100.GetType().
//                GetMethod("Calculate");
//            Console.WriteLine(Calculate.Invoke(sum1To100, null));
//        }
//    }
//}
