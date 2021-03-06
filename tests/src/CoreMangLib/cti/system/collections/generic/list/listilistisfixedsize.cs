using System;
using System.Collections.Generic;
using System.Collections;
/// <summary>
///IsFixedSize
/// </summary>
public class ListIListIsFixedSize
{
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        return retVal;
    }

    #region Positive Test Cases
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: this IsFixedSize property always returns false.");

        try
        {
            int[] iArray = { 1, 9, 3, 6, 5, 8, 7, 2, 4, 0 };
            List<int> listObject = new List<int>(iArray);
            bool actualValue=((IList)listObject).IsFixedSize;
            if (actualValue)
            {
                TestLibrary.TestFramework.LogError("001.1", "calling IsFixedSize property should return false.");
                retVal = false;
            }
            string[] sArray = { "1", "9", "3", "6", "5", "8", "7", "2", "4", "0" };
            List<string> listObject1 = new List<string>(sArray);
            actualValue = ((IList)listObject).IsFixedSize;
            if (actualValue)
            {
                TestLibrary.TestFramework.LogError("001.2", "calling IsFixedSize property should return false.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
   
    #endregion
    #endregion

    public static int Main()
    {
        ListIListIsFixedSize test = new ListIListIsFixedSize();

        TestLibrary.TestFramework.BeginTestCase("ListIListIsFixedSize");

        if (test.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
}
