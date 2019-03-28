using Microsoft.VisualStudio.TestTools.UnitTesting;
using AntheaChallenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntheaChallenges.Tests
{
    [TestClass()]
    public class AntheaStringsTests
    {
        [TestMethod()]
        public void AddEmptyTest() //Step 1
        {
            AntheaStrings challenge = new AntheaStrings();
            Assert.AreEqual(challenge.Add(""), 0);
        }

        [TestMethod()]
        public void AddOneNumberTest1() //Step 1
        {
            AntheaStrings challenge = new AntheaStrings();
            Assert.AreEqual(challenge.Add("1"), 1);
        }

        [TestMethod()]
        public void AddOneNumberTest2() //Step 1
        {
            AntheaStrings challenge = new AntheaStrings();
            Assert.AreEqual(challenge.Add("99999999"), 0);
        }

        [TestMethod()]
        public void AddOneNumberTest3() //Step 1
        {
            AntheaStrings challenge = new AntheaStrings();
            try
            {
                challenge.Add("-1");
                Assert.Fail();
            }
            catch (Exception ex)
            {
                if (!ex.Message.Contains("negatives not allowed:"))
                    Assert.Fail();
            }
        }

        [TestMethod()]
        public void AddTwoNumbersTest() //Step 1
        {
            AntheaStrings challenge = new AntheaStrings();
            Assert.AreEqual(challenge.Add("1,2"), 3);
        }

        [TestMethod()]
        public void AddMultipleNumbersTest()  //Step 2
        {
            AntheaStrings challenge = new AntheaStrings();
            Assert.AreEqual(challenge.Add("1,2,3,4,5,6"), 21);
        }

        [TestMethod()]  //Step 3
        public void AddNoNegativeNumbersTest1()
        {
            AntheaStrings challenge = new AntheaStrings();
            try
            {
                challenge.Add("1,2,-3");
                Assert.Fail();
            }
            catch (Exception ex)
            {
                if (!ex.Message.Contains("negatives not allowed:"))
                    Assert.Fail();
            }
        }

        [TestMethod()]  //Step 3
        public void AddNoNegativeNumbersTest2()
        {
            AntheaStrings challenge = new AntheaStrings();
            try
            {
                challenge.Add("1,2,-3,-40,-77");
                Assert.Fail();
            }
            catch (Exception ex)
            {
                if (!ex.Message.Contains("negatives not allowed:"))
                    Assert.Fail();
            }
        }
  
        [TestMethod()]
        public void AddBiggerThanThousandTest()   //Step 4
        {
            AntheaStrings challenge = new AntheaStrings();
            Assert.AreEqual(challenge.Add("1,2,1001"), 3);
        }

        [TestMethod()]
        public void AddWithCustomDelimiter1Test()  //Step 5
        {
            AntheaStrings challenge = new AntheaStrings();
            Assert.AreEqual(challenge.Add("//[***]//1***2***3"), 6);
        }


        [TestMethod()]
        public void AddWithCustomDelimiter2Test()  //Step 5
        {
            AntheaStrings challenge = new AntheaStrings();
            Assert.AreEqual(challenge.Add("1@2@3"), 6);
        }

        [TestMethod()]
        public void AddWithCustomMultipleDelimiter1Test()  //Step 6
        {
            AntheaStrings challenge = new AntheaStrings();
            Assert.AreEqual(challenge.Add("//[*][%]//1*2%3"), 6);
        }

        [TestMethod()]
        public void AddWithCustomMultipleDelimiter2Test()  //Step 7
        {
            AntheaStrings challenge = new AntheaStrings();
            Assert.AreEqual(challenge.Add("//[????][**][$$$$$$$$$]//1????2**3$$$$$$$$$10"), 16);
        }

        [TestMethod()]
        public void AddSuperRandomStringTest()  //Bonus test with random string
        {
            AntheaStrings challenge = new AntheaStrings();
            Assert.AreEqual(challenge.Add("dfdsfhsdh3dhsdfjsdhjsdhfs6.,..@"), 9);
        }

    }
}