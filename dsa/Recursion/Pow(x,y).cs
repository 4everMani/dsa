﻿namespace Recursion;

public class Pow_x_y_
{
    // Implement pow(x, n), which calculates x raised to the power n (i.e., xn).

    // Example 1:

    // Input: x = 2.00000, n = 10
    // Output: 1024.00000
    // Example 2:

    // Input: x = 2.10000, n = 3
    // Output: 9.26100
    // Example 3:

    // Input: x = 2.00000, n = -2
    // Output: 0.25000
    // Explanation: 2-2 = 1/22 = 1/4 = 0.25

    public static void Solution(double x, int n)
    {
        System.Console.WriteLine(MyPow(x, n));
    }
    // Time: O(logn) 
    // Space: O (logn)
    public static double MyPow(double x, int n) {
        if (n == 0) return 1;
        if (n < 0) {
            x = 1 / x;
            n = -n;
        }
        return PowHelper(x, n);
    }
    private static double PowHelper(double x, int n)
    {
        if (n == 0) return 1;
        double half = PowHelper(x, n / 2);
        if (n % 2 == 0) {
            return half * half;
        } 
        else {
            return half * half * x;
        }

    }
}
