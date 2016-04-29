// File/Project Prolog
// Name: Jonathan Spalding
// CS 1400 Section X01
// Project: lab_01_JCS_V1._0
// Date: 1/7/2016 7:38 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace lab_01_JCS_V1._0
{
    static public class Program
    {
        static void Main()
        {
            // This program displays my student information
            string name = "Jonathan Spalding";
            string course = "CNS 1400";
            string section = "X01";
            string project = "Lab One";

            // This code displays the strings on the console
            WriteLine("Name: {0}", name);
            WriteLine("Course: {0}", course);
            WriteLine("Section: {0}", section);
            WriteLine("Project: {0}", project);

            WriteLine("Press any key to continue");
            ReadKey(true);
        }// End Main
    }//End class Program
}//End namespace lab_01_JCS_V1._0

