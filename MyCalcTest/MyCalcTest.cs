using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabEx
{
    [TestClass]
    public class MyCalcTest
    {
        // [TestMethod]
        // public void TestAddMethod()
        // {
        //     int result = MyCalc.Add(50,50);
        //     int expectedresult=100;
        //     Assert.AreEqual(expectedresult,result,"Test Method Fail");
        // }
        
        //  [TestMethod]
        // public void TestSubMethod()
        // {
        //     int result = MyCalc.Sub(50,10);
        //     int expectedresult=100;
        //     Assert.AreEqual(expectedresult,result,"Test Method Fail");
        // }

        //  [TestMethod]
        // public void TestMulMethod()
        // {
        //     int result = MyCalc.Mul(5,10);
        //     int expectedresult=50;
        //     Assert.AreEqual(expectedresult,result,"Test Method Fail");
        // }

        //  [TestMethod]
        // public void TestDivMethod()
        // {
        //     int result = MyCalc.Div(50,5);
        //     int expectedresult=10;
        //     Assert.AreEqual(expectedresult,result,"Test Method Fail");
        // }

        // [TestMethod]
        // public void TestPowMethod()
        // {
        //     int result = MyCalc.pow(10,2);
        //     int expectedresult=100;
        //     Assert.AreEqual(expectedresult,result,"Test Method Fail");
        // }

         [DataTestMethod]
         [DataRow(10,20,30)]
         [DataRow(10,30,40)]
         [DataRow(20,30,40)]
        public void TestDataAddMethod(int a,int b,int expectedresult)
        {
            int result = MyCalc.Add(a,b);
            Assert.AreEqual(expectedresult,result,"Test Method Fail");
        }

        [DataTestMethod]
         [DataRow(10,20,30)]
         [DataRow(10,30,40)]
         [DataRow(20,30,40)]
        public void TestDataSubMethod(int a,int b,int expectedresult)
        {
            int result = MyCalc.Sub(a,b);
            Assert.AreEqual(expectedresult,result,"Test Method Fail");
        }
    }
    }

