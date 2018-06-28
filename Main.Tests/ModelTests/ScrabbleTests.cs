using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class Scrabble
  {
    private bool test = false;
    [TestInitialize]
    public void TestInit()
    {
      test = true;
    }
    [TestMethod]
    public void Return_True()
    {
      Word word = new Word();
      Assert.AreEqual(test,word.Default());
    }
    [TestMethod]
    public void Return_Score_1st_True()
    {
      Word word = new Word("ABCD");
      Assert.AreEqual(9,word.Score());
    }
    [TestMethod]
    public void Return_Score_2nd_True()
    {
      Word word = new Word("EFGH");
      Assert.AreEqual(11,word.Score());
    }
    [TestMethod]
    public void Return_Score_3rd_True()
    {
      Word word = new Word("IJKLM");
      Assert.AreEqual(18,word.Score());
    }
    [TestMethod]
    public void Return_Score_4th_True()
    {
      Word word = new Word("453}{:<>?/.,}");
      Assert.AreEqual(0,word.Score());
    }
    [TestMethod]
    public void Return_Score_5th_True()
    {
      Word word = new Word("7G108:waA");
      Assert.AreEqual(8,word.Score());
    }
    [TestMethod]
    public void Return_Score_6th_True()
    {
      Word word = new Word("A");
      Assert.AreEqual(1,word.Score());
    }
  }
}
