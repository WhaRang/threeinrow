using NUnit.Framework;

namespace Tests.Custom
{
    public static class CustomAssertions
    {
        public static void AreEqual(bool[][] expected, bool[][] actual)
        {
            if (expected == null || actual == null)
            {
                Assert.AreEqual(expected, actual, "One or both arrays are null.");
                return;
            }

            Assert.AreEqual(expected.Length, actual.Length, "Arrays do not have the same number of rows.");

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i].Length, actual[i].Length, $"Row {i} does not have the same number of columns.");

                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j], $"Element at ({i},{j}) is different.");
                }
            }
        }
    }
}