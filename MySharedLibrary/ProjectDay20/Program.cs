using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDay20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "123";

            // Example usage of utility methods
            bool isNumber = MySharedLibrary.UtilityClass.IsNumber(userInput);
            MySharedLibrary.UtilityClass.LogMessage($"User input: {userInput}, IsNumber: {isNumber}");
            string encryptedText = MySharedLibrary.UtilityClass.Encrypt("SensitiveData");
            Console.WriteLine(encryptedText);
        }
    }
}
