#pragma warning disable SA1202 // disable pub before priv
#pragma warning disable SA1600 // disable doc

using System.Collections.Generic;
using NUnit.Framework;

/// <summary>
/// X Test Case data.
/// </summary>
public static class OverwriteXTestData
{
    public static IEnumerable<TestCaseData> A_Test_TestData_Core()
    {
        yield return new TestCaseData(6).SetArgDisplayNames("it0 5");
        yield return new TestCaseData(6).SetArgDisplayNames("it3 8");
    }

    public static IEnumerable<TestCaseData> A_Test_TestData()
    {
        foreach (var testCase in A_Test_TestData_Core())
        {
            yield return testCase;
        }

        yield return new TestCaseData(6).SetArgDisplayNames("it1 6");
        yield return new TestCaseData(7).SetArgDisplayNames("it2 7");
    }
}
