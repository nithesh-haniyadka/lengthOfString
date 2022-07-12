namespace unitTestcases
{

   // Create a unit test project using Xunit and write test cases to find length of string for "", "123", "123456789010", NULL
    public class UnitTest1
    {
        string s1 = "";
        [Fact]
        public void Test1()
        {
            if (s1 == "")
            {
                Console.WriteLine("s1 equals empty string.");
            }

        }
        [Fact]
        public void LengthTest()
    {
        // Satisfies rule: TestForEmptyStringsUsingStringLength.
        if (s1 != null && s1.Length == 0)
        {
            Console.WriteLine("s1.Length == 0.");
        }
    }
        [Fact]
        public void NullOrEmptyTest()
        {
            // Satisfies rule: TestForEmptyStringsUsingStringLength.
            if (!String.IsNullOrEmpty(s1))
            {
                Console.WriteLine("s1 != null and s1.Length != 0.");
            }
        }

        string s2 = "123";
        [Fact]
        public void Test2()
        {
            if (s2 == "123")
            {
                Console.WriteLine("s1 not equals to empty string");
            }

        }
        [Fact]
        public void LengthTest2()
        {
            // Satisfies rule: TestForEmptyStringsUsingStringLength.
            if (s2 != null && s1.Length != 0)
            {
                Console.WriteLine("length is not equals to 0");
            }
        }
        [Fact]
        public void NullOrEmptyTest2()
        {
            // Satisfies rule: TestForEmptyStringsUsingStringLength.
            if (!String.IsNullOrEmpty(s2))
            {
                Console.WriteLine("not equal to empty or Null");
            }
        }


        string s3 = "123456789010";
        [Fact]
        public void Test3()
        {
            if (s3 == "123456789010")
            {
                Console.WriteLine("s3 not equals to empty string");
            }

        }
        [Fact]
        public void LengthTest3()
        {
            // Satisfies rule: TestForEmptyStringsUsingStringLength.
            if (s3 != null && s3.Length != 0)
            {
                Console.WriteLine("length is not equals to 0");
            }
        }
        [Fact]
        public void NullOrEmptyTest3()
        {
            // Satisfies rule: TestForEmptyStringsUsingStringLength.
            if (!String.IsNullOrEmpty(s3))
            {
                Console.WriteLine("not equal to empty or Null");
            }
        }

        string s4 = null;
            public void NullOrEmptyTest4()
        {
            // Satisfies rule: TestForEmptyStringsUsingStringLength.
            if (!String.IsNullOrEmpty(s4))
            {
                Console.WriteLine("s4 is null");
            }
        }
    }
}