/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;

namespace Definite_Assignment_and_Default_Values
{
    class Program
    {
        static void Main()
        {
            // C# enforces a definite assignment policy.
            // In practice, outside of an unsafe context, it's impossible to access uninitialized memory.
            // Definitive Assignment has three implications:
            // Local variables must be assigned a value before they can be read.
            // Function arguments must be supplied when a method is called. (unless marked as optional.)
            // All other variables (such as fields and array elements) are automatically initialized by the runtime.
            // For example, the following code results in a runtime error:
            int x;
            x = 1;  // Without this line, there will be a compile-time error
            Console.WriteLine(x);
            // Fields and array elements are automatically initialized with the default values of that type.
            /*          **************************************************
             *          *             Type           *   Default Value   *
             *          **************************************************
             *          * All reference types        *  null             *
             *          * All numeric and enum types *  0                *
             *          * char type                  *  '\0'             *
             *          * bool type                  *  false            *
             *          **************************************************
             */
        }
        class Test
        {
            // The following code outputs 0, because array elements are implicitly assigned to their default values:
            static int y;
            static void MainTest()
            {
                Console.WriteLine(y);   // 0
            }
        }
    }
}
