using System;

namespace LabEx
{
    public class MyCalc
    {
         
        public static int Add(int u1, int u2)
       {
            return u1+u2;
       }

        public static int Sub(int u1, int u2)
       {
            return u1-u2;
       }
        public static int Mul(int u1, int u2)
       {
            return u1*u2;
       }
        public static int Div(int u1, int u2)
       {
            return u1/u2;
       }
        public static double Power(double u1, double u2)
       {
           double  power = Math.Pow(u1,u2);
             return power;
       }
      public static int pow (int n1, int n2)
      {
        int n3=n1;
        for(int i=1; i<n2;i++)
        {
            n3=n1*n3;
        }
        return  n3;

      }
      public static int p (int p1, int p2)
      {
        int p3=p1;
        int i=1;
        while (i<p2);
        i++;
        
        {
            p3=p1*p3;
        }
        return  p3;
    }
}
    }
    

