using System;
/// <summary>
///ctor(System.String,System.Exception)
/// </summary>
public class ArrayTypeMismatchExceptionctor3
{
    public static int Main()
    {
        ArrayTypeMismatchExceptionctor3 ArrayTypeMismatchExceptionctor3 = new ArrayTypeMismatchExceptionctor3();
        TestLibrary.TestFramework.BeginTestCase("ArrayTypeMismatchExceptionctor3");
        if (ArrayTypeMismatchExceptionctor3.RunTests())
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
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Create a new ArrayTypeMismatchException instance. ");
        try
        {
            string expectValue = "Hello";
            ArgumentException myAieldExcption = new ArgumentException();
            ArrayTypeMismatchException myException = new ArrayTypeMismatchException(expectValue, myAieldExcption);
            if (myException == null)
            {
                TestLibrary.TestFramework.LogError("001.1", " the constructor should not return  null. ");
                retVal = false;
            }
            else
            {
                if (myException.Message!=expectValue)
                {
                    TestLibrary.TestFramework.LogError("001.2", " the expection message should return " + expectValue);
                    retVal = false;
                }
                if (!(myException.InnerException is ArgumentException))
                {
                    TestLibrary.TestFramework.LogError("001.3", " the inner expection  should return  the specified exception.");
                    retVal = false;
                }
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: the string parameter is null and the inner exception parameter is also null. ");
        try
        {
            string expectValue = null;
            ArrayTypeMismatchException myException = new ArrayTypeMismatchException(expectValue, null);
            if (myException == null)
            {
                TestLibrary.TestFramework.LogError("002.1", " the constructor should not return  null. ");
                retVal = false;
            }
            else
            {
                if (myException.Message == expectValue)
                {
                    TestLibrary.TestFramework.LogError("002.2", " the expection message should return a default message when the  string parameter is null. ");
                    retVal = false;
                }
                if (myException.InnerException !=null)
                {
                    TestLibrary.TestFramework.LogError("002.3", " the inner expection  should return  the specified null.");
                    retVal = false;
                }
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }

    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest3()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest3: the string parameter is empty. ");
        try
        {
            string expectValue =string.Empty;
            ArgumentException myAieldExcption = new ArgumentException();
            ArrayTypeMismatchException myException = new ArrayTypeMismatchException(expectValue, myAieldExcption);
            if (myException == null)
            {
                TestLibrary.TestFramework.LogError("003.1", " the constructor should not return  null. ");
                retVal = false;
            }
            else
            {
                if (myException.Message != expectValue)
                {
                    TestLibrary.TestFramework.LogError("003.2", " the expection message should return " + expectValue);
                    retVal = false;
                }
                if (!(myException.InnerException is ArgumentException))
                {
                    TestLibrary.TestFramework.LogError("003.3", " the inner expection  should return  the specified exception.");
                    retVal = false;
                }
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("003.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
   
}

