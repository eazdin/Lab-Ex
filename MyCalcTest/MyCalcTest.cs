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
            Assert.AreEqual(expectedresult,result,"AddTest Method Fail");
        }

        [DataTestMethod]
         [DataRow(50,20,30)]
         [DataRow(10,30,40)]
         [DataRow(70,30,40)]
        public void TestDataSubMethod(int a,int b,int expectedresult)
        {
            int result = MyCalc.Sub(a,b);
            Assert.AreEqual(expectedresult,result,"SubTest Method Fail");
        }

         [DataTestMethod]
         [DataRow(10,2,20)]
         [DataRow(10,3,30)]
         [DataRow(70,30,40)]
         [DataRow(10,30,300)]
        public void TestDataMulMethod(int a,int b,int expectedresult)
        {
            int result = MyCalc.Mul(a,b);
            Assert.AreEqual(expectedresult,result,"MulTest Method Fail");
        }

        [DataTestMethod]
         [DataRow(10,2,5)]
         [DataRow(10,3,3)]
         [DataRow(900,30,30)]
        public void TestDataDivMethod(int a,int b,int expectedresult)
        {
            int result = MyCalc.Div(a,b);
            Assert.AreEqual(expectedresult,result,"DivTest Method Fail");
        }

         [DataTestMethod]
         [DataRow(10,2,100)]
         [DataRow(2,3,8)]
         [DataRow(9,3,31)]
        public void TestDatapowMethod(int a,int b,int expectedresult)
        {
            int result = MyCalc.pow(a,b);
            Assert.AreEqual(expectedresult,result,"powTest Method Fail");
        }
    }
    }

