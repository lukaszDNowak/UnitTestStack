﻿using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using stack;

namespace StackTest
{
    [TestClass]
    public class StackUnitTest
    {
        [TestMethod]
        public void TestPush()
        {
            Stack<int> st = new Stack<int>();
            st.Push(200);
            Assert.AreEqual(st.Pop(), 200);
        }
        [TestMethod]
        public void TestPop()
        {
            Stack<string> st = new Stack<string>();
            st.Push("S");
            st.Push("T");
            st.Push("A");

            Assert.AreEqual(st.Pop(), "A");
            Assert.AreEqual(st.Pop(), "T");
            Assert.AreEqual(st.Pop(), "S");
        }

        [TestMethod]
        public void TestPeek()
        {
            Stack<string> st = new Stack<string>();
            st.Push("S");
            st.Push("T");
            st.Push("A");

            Assert.AreSame(st.Peek(), "A"); 
        }

        [TestMethod]
        public void StackIsEmpty()
        {
            Stack<string> st = new Stack<string>();

            Assert.AreEqual(st.Count,0);
        }
        [TestMethod]
        public void StackIsNotEmpty()
        {
            Stack<string> st = new Stack<string>();
            st.Push("Nie jest pusty");
            Assert.AreEqual(st.Count,1);
        }
    }
}