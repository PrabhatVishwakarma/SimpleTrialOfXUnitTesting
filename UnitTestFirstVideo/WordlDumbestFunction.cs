using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFirstVideo
{
    public class WordlDumbestFunction
    {
        public string returnTestCasePassedIfZero(int num)
        {
            if (num==0)
            {
                return "TestCasePassed";
            }
            else
            {
                return "TestCaseFailed";
            }
        }

    }
}
