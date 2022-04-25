//This is my own way of finding the sum of 1-2+3-4+5-6+..+n
using System;

namespace myalgo
{
    public class program 
    {
        public static void Main(string[] args)
        { 
            int i,j,temp=0, sum = 0;
            Console.Write("Enter the limit: ");
            int n = int.Parse(Console.ReadLine());
            if(n%2==0)
            {
                for(i=1,j=i+1;i<=n-1&&j<=n;i=i+2,j=j+2)
                {
                    sum = sum+ (i-j);
                }
            }
            else if(n%2 != 0)
            {
                for(i=1,j=i+1;i<=n&&j<=n+1;i=i+2,j=j+2)
                {
                    sum = sum + (i-j);
                    temp = j;
                }
                sum = sum + temp;
            }
            Console.WriteLine($"{sum} is the sum");
        }
    }
}