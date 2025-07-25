namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing UnBoxing

            #region Boxing [value Type => reference type] safe

            //int x = 100;
            //object obj = x; // Boxing impilictli

            //obj = 12.2; // casting from value type [Double] => To reference type [object] --> Boxing
            //obj = 'A'; // casting from value type [Char] => To reference Type [object] --> Boxing
            //obj = 12.12F; //casting from value type [float] => To reference type [object] --> Boxing

            // safe casting





            #endregion

            #region UnBoxing [reference type => value tpye] unsafe

            //object obj = "Ola";
            //int x = (int)obj;
            //Console.WriteLine(x); // InvalidCastException:



            #endregion




            #endregion


            #region nullable value Type [C# version 2.0 (2005) ]

            #region exmple01
            //int x = 10;
            ////x = null // invalid
            //Nullable<int> y = 10;
            //y = null; // valid
            //// you can hold int and null

            //// sentax sugar nullable Type

            //int? z = 100;
            //z = null;

            #endregion

            #region exmple02

            //int x = 10;
            //int? y = x; // valid - implicitly casting

            //// x can hold int
            //// y can hold int + null;



            //int? x = 10;
            //int y = (int)x; // explicit casting unsafe

            //int y;
            //int? x = 10;
            //if(x is not null)
            // {
            //      y = (int)x;
            // }
            // else
            // {
            //     y = 0;
            // }

            //if (x.HasValue) {
            //    y = x.Value;
            //}
            //else
            //{
            //    y = 0;
            //}

            //y = x.HasValue ? x.Value : 0; 

            //y = x ?? 0; // null callincing Operator

            //y = x.GetValueOrDefault(); 

            //Console.WriteLine(y);


            #endregion


            #endregion



            #region nullable reference Type  [c# 8.0 (2019)]
            //            #region exmple01

            //#nullable disable
            //            string? name = "Ola";
            //            name = null;

            //#nullable enable
            //            string x = "Route";
            //            x = null !; // null forgiving Operator
            //            #endregion


            #endregion

            #region null-conditional | propagation operator
            //int[] nums = { 1, 2, 3, 4, 5 };


            //   for (int i = 0; i < nums?.Length; i++) { // طريقة 1

            //    Console.WriteLine(nums[i]);
            //}


            //if(nums is not null) // طريقة 2
            //{
            //    for (int i = 0; i < nums.Length; i++) {
            //        Console.WriteLine(nums[i]);
            //    }

            //int arrayLength = nums?.Length ?? 0; // طريقة1
            //int ? arrayLength = nums?.Length; // طريقة 2




            #endregion
             
            #region Enum



            #endregion


        }
    }
}
