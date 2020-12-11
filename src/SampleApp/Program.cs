using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using FluentAssertions;

class Solution
{

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        var queue = new Queue<int>(a);

        for (int i = 0; i < d; i++)
        {
            queue.Enqueue(queue.Dequeue());
        }

        return queue.ToArray();
    }

    static void Main(string[] args)
    {
        int n = 5;

        int d = 4;

        int[] a = { 1, 2, 3, 4, 5 };

        rotLeft(a, d).Should().BeEquivalentTo(
            new int[] { 5, 1, 2, 3, 4 }
            );

    }
}
