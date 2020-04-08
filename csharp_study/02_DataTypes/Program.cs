using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // c# 은 3가지 value 타입을 제공한다.
            // 1. Value Data Type  =>  short , int , char, float, double , etc ...
            // 2. Reference Data Type  => String , Class , Object , Interface 
            // 3. Pointer Data Type  => Pointers


            // Value Type 은 2가지가 있다.
            // 미리 정의된 데이터 타입과 Integer, Boolean, Float, etc, 
            // 사용자 정의 데이터 타입으로 나눌 수 있다. Structure, Enumerations, etc

            /*
            char                    1 byte          -128 to 127
            signed char             1 byte          -128 to 127
            unsigned char           1 byte          0 to 127
            short                   2 byte          -32,768 to 32,767
            signed short            2 byte          -32,768 to 32,767
            unsigned short          2 byte          0 to 65,535
            int                     4 byte          -2,147,483,648 to - 2,147,483,647
            signed int              4 byte          -2,147,483,648 to - 2,147,483,647
            unsigned int            4 byte          0 to 4,294,967,295
            long                    8 byte          ?9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            signed long             8 byte          ?9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            unsigned long           8 byte          0 - 18,446,744,073,709,551,615
            float                   4 byte          1.5 * 10 - 45 - 3.4 * 1038, 7 - digit precision
            double                  8 byte          5.0 * 10 - 324 - 1.7 * 10308, 15 - digit precision
            decimal                 16 byte         at least - 7.9 * 10 ? 28 - 7.9 * 1028, with at least 28 - digit precision
            */


            //참조타입  2가지가 있다.
            // 미리 정의된 데이터 타입과 Objects, String, 
            // 사용자 정의 데이터 타입으로 나눌 수 있다. Class, Interface 


            // pointer는 잘 모르겟따.
            // 선언하는 방법은  * 을 사용한다 . int * a; 








        }
    }
}
