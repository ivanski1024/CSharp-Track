using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Phonebook;

namespace Phonebook.Tests
{
    [TestClass]
    public class PhonebookDemoTest
    {
        //[TestMethod]
        //public void ProgramTest01()
        //{
        //    StreamReader inputFile = new StreamReader("test.001.in.txt");
        //    StreamReader outputFile = new StreamReader("test.001.out.txt");

        //    string expectedOutput = null;
        //    using (outputFile)
        //    {
        //        if (!outputFile.EndOfStream)
        //        {
        //            expectedOutput = outputFile.ReadToEnd();
        //        }
        //    }
        //    List<string> input = new List<string>();
        //    using (inputFile)
        //    {
        //        while (!inputFile.EndOfStream)
        //        {
        //            input.Add(inputFile.ReadLine());
        //        }
        //    }

        //    string output = PhonebookDemo.RunProgram(input.ToArray());
        //    output = output.Trim();
        //    expectedOutput = expectedOutput.Trim();
        //    Assert.AreEqual(output, expectedOutput);
        //}

        //[TestMethod]
        //public void ProgramTest02()
        //{
        //    StreamReader inputFile = new StreamReader("test.002.in.txt");
        //    StreamReader outputFile = new StreamReader("test.002.out.txt");

        //    string expectedOutput = null;
        //    using (outputFile)
        //    {
        //        if (!outputFile.EndOfStream)
        //        {
        //            expectedOutput = outputFile.ReadToEnd();
        //        }
        //    }
        //    List<string> input = new List<string>();
        //    using (inputFile)
        //    {
        //        while (!inputFile.EndOfStream)
        //        {
        //            input.Add(inputFile.ReadLine());
        //        }
        //    }

        //    string output = PhonebookDemo.RunProgram(input.ToArray());
        //    output = output.Trim();
        //    expectedOutput = expectedOutput.Trim();
        //    Assert.AreEqual(expectedOutput, output);
        //}

        //[TestMethod]
        //public void ProgramTest03()
        //{
        //    StreamReader inputFile = new StreamReader("test.003.in.txt");
        //    StreamReader outputFile = new StreamReader("test.003.out.txt");

        //    string expectedOutput = null;
        //    using (outputFile)
        //    {
        //        if (!outputFile.EndOfStream)
        //        {
        //            expectedOutput = outputFile.ReadToEnd();
        //        }
        //    }
        //    List<string> input = new List<string>();
        //    using (inputFile)
        //    {
        //        while (!inputFile.EndOfStream)
        //        {
        //            input.Add(inputFile.ReadLine());
        //        }
        //    }

        //    string output = PhonebookDemo.RunProgram(input.ToArray());
        //    output = output.Trim();
        //    expectedOutput = expectedOutput.Trim();
        //    Assert.AreEqual(expectedOutput, output);
        //}

        //[TestMethod]
        //public void ProgramTest04()
        //{
        //    StreamReader inputFile = new StreamReader("test.004.in.txt");
        //    StreamReader outputFile = new StreamReader("test.004.out.txt");

        //    string expectedOutput = null;
        //    using (outputFile)
        //    {
        //        if (!outputFile.EndOfStream)
        //        {
        //            expectedOutput = outputFile.ReadToEnd();
        //        }
        //    }
        //    List<string> input = new List<string>();
        //    using (inputFile)
        //    {
        //        while (!inputFile.EndOfStream)
        //        {
        //            input.Add(inputFile.ReadLine());
        //        }
        //    }

        //    string output = PhonebookDemo.RunProgram(input.ToArray());
        //    output = output.Trim();
        //    expectedOutput = expectedOutput.Trim();
        //    Assert.AreEqual(expectedOutput, output);
        //}

        //[TestMethod]
        //public void ProgramTest05()
        //{
        //    StreamReader inputFile = new StreamReader("test.005.in.txt");
        //    StreamReader outputFile = new StreamReader("test.005.out.txt");

        //    string expectedOutput = null;
        //    using (outputFile)
        //    {
        //        if (!outputFile.EndOfStream)
        //        {
        //            expectedOutput = outputFile.ReadToEnd();
        //        }
        //    }
        //    List<string> input = new List<string>();
        //    using (inputFile)
        //    {
        //        while (!inputFile.EndOfStream)
        //        {
        //            input.Add(inputFile.ReadLine());
        //        }
        //    }

        //    string output = PhonebookDemo.RunProgram(input.ToArray());
        //    output = output.Trim();
        //    expectedOutput = expectedOutput.Trim();
        //    Assert.AreEqual(expectedOutput, output);
        //}

        //[TestMethod]
        //public void ProgramTest06()
        //{
        //    StreamReader inputFile = new StreamReader("test.006.in.txt");
        //    StreamReader outputFile = new StreamReader("test.006.out.txt");

        //    string expectedOutput = null;
        //    using (outputFile)
        //    {
        //        if (!outputFile.EndOfStream)
        //        {
        //            expectedOutput = outputFile.ReadToEnd();
        //        }
        //    }
        //    List<string> input = new List<string>();
        //    using (inputFile)
        //    {
        //        while (!inputFile.EndOfStream)
        //        {
        //            input.Add(inputFile.ReadLine());
        //        }
        //    }

        //    string output = PhonebookDemo.RunProgram(input.ToArray());
        //    output = output.Trim();
        //    expectedOutput = expectedOutput.Trim();
        //    Assert.AreEqual(expectedOutput, output);
        //}

        //[TestMethod]
        //public void ProgramTest07()
        //{
        //    StreamReader inputFile = new StreamReader("test.007.in.txt");
        //    StreamReader outputFile = new StreamReader("test.007.out.txt");

        //    string expectedOutput = null;
        //    using (outputFile)
        //    {
        //        if (!outputFile.EndOfStream)
        //        {
        //            expectedOutput = outputFile.ReadToEnd();
        //        }
        //    }
        //    List<string> input = new List<string>();
        //    using (inputFile)
        //    {
        //        while (!inputFile.EndOfStream)
        //        {
        //            input.Add(inputFile.ReadLine());
        //        }
        //    }

        //    string output = PhonebookDemo.RunProgram(input.ToArray());
        //    output = output.Trim();
        //    expectedOutput = expectedOutput.Trim();
        //    Assert.AreEqual(expectedOutput, output);
        //}

        //[TestMethod]
        //public void ProgramTest08()
        //{
        //    StreamReader inputFile = new StreamReader("test.008.in.txt");
        //    StreamReader outputFile = new StreamReader("test.008.out.txt");

        //    string expectedOutput = null;
        //    using (outputFile)
        //    {
        //        if (!outputFile.EndOfStream)
        //        {
        //            expectedOutput = outputFile.ReadToEnd();
        //        }
        //    }
        //    List<string> input = new List<string>();
        //    using (inputFile)
        //    {
        //        while (!inputFile.EndOfStream)
        //        {
        //            input.Add(inputFile.ReadLine());
        //        }
        //    }

        //    string output = PhonebookDemo.RunProgram(input.ToArray());
        //    output = output.Trim();
        //    expectedOutput = expectedOutput.Trim();
        //    Assert.AreEqual(expectedOutput, output);
        //}

        //[TestMethod]
        //public void ProgramTest09()
        //{
        //    StreamReader inputFile = new StreamReader("test.009.in.txt");
        //    StreamReader outputFile = new StreamReader("test.009.out.txt");

        //    string expectedOutput = null;
        //    using (outputFile)
        //    {
        //        if (!outputFile.EndOfStream)
        //        {
        //            expectedOutput = outputFile.ReadToEnd();
        //        }
        //    }
        //    List<string> input = new List<string>();
        //    using (inputFile)
        //    {
        //        while (!inputFile.EndOfStream)
        //        {
        //            input.Add(inputFile.ReadLine());
        //        }
        //    }

        //    string output = PhonebookDemo.RunProgram(input.ToArray());
        //    output = output.Trim();
        //    expectedOutput = expectedOutput.Trim();
        //    Assert.AreEqual(expectedOutput, output);
        //}

        //[TestMethod]
        //public void ProgramTest10()
        //{
        //    StreamReader inputFile = new StreamReader("test.010.in.txt");
        //    StreamReader outputFile = new StreamReader("test.010.out.txt");

        //    string expectedOutput = null;
        //    using (outputFile)
        //    {
        //        if (!outputFile.EndOfStream)
        //        {
        //            expectedOutput = outputFile.ReadToEnd();
        //        }
        //    }
        //    List<string> input = new List<string>();
        //    using (inputFile)
        //    {
        //        while (!inputFile.EndOfStream)
        //        {
        //            input.Add(inputFile.ReadLine());
        //        }
        //    }

        //    string output = PhonebookDemo.RunProgram(input.ToArray());
        //    output = output.Trim();
        //    expectedOutput = expectedOutput.Trim();
        //    Assert.AreEqual(expectedOutput, output);
        //}
    }
}