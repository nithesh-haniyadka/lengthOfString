using findLengthOftheString;


namespace unitTestcases
{

    
// Create a unit test project using Xunit and write test cases to find length of string for "", "123", "123456789010", NULL
    public static class UnitTest1
    {
        
        [Fact]
        public static void checkUnitTest()
        {
             
            var test = LengthHelper.findLength("123");
            Assert.Equal(3, test);

        }

        [Fact]
        public static void checkUnitTest1()
        {

            var test = LengthHelper.findLength("");
            Assert.Equal(0, test);

        }

        [Fact]
        public static void checkUnitTest2()
        {
            var test = LengthHelper.findLength("123456789010");
            Assert.Equal(12, test);

        }

        [Fact]
     
        public static void NullOrEmptyTest()
        {
            string str = null;
            bool b3 = string.IsNullOrEmpty(str);
            Assert.True(b3);


        }



    }
}