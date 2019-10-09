using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Packer.Models;

namespace Packer.Tests
{
    [TestClass]
    public class PackerTest : IDisposable
    {
        public void Dispose()
        {
        Place.ClearAll();
        }

    }
}