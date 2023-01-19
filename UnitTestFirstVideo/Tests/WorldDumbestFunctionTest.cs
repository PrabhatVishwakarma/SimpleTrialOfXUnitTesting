using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFirstVideo.Tests
{
    public class WorldDumbestFunctionTest
    {
        public static void WorldDumbestFunction_ReturnTestCasePassedIfZero_ReturnString()
        {
            try
            {
                //Arrange - Go get your variable, whatever you need,you class, go get functions
                int num = 0;
                WordlDumbestFunction worldsDumbest = new WordlDumbestFunction();
                //Act - Execute this function
                string result = worldsDumbest.returnTestCasePassedIfZero(num);

                //Assert - what ever we returned is it what we want
                if(result == "TestCasePassed")
                {
                    Console.WriteLine("Passed : WorldDumbestFunction_ReturnTestCasePassedIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("Failed : WorldDumbestFunction_ReturnTestCasePassedIfZero_ReturnString");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
