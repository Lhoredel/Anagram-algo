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

class Result
{

    /*
     * Complete the 'anagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int anagram(string s)
    {
        if (s.Length % 2 != 0)
        return -1;
        
        int mid = s.Length / 2;
        string s1 = s.Substring(0, mid);
        string s2 = s.Substring(mid);
        
        int[] freq1 = new int[26];
        int[] freq2 = new int[26];
        
        foreach (char c in s1)
        {
        freq1[c - 'a']++;
        }
        foreach (char c in s2)
        {
        freq2[c - 'a']++;
        }
        
        int changes = 0;
        for (int i = 0; i < 26; i++)
        {
        if (freq2[i] > freq1[i])
        {
            changes += freq2[i] - freq1[i];
        }
    }
    
    return changes;
}

    }



class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.anagram(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
