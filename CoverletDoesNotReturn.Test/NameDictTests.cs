using System;
using Xunit;

namespace CoverletDoesNotReturn.Test
{
    public class NameDictTests
    {
        [Fact]
        public void Add_WhenSuccess()
        {
            string propertyName = "name";
            object? value = null;
            new NameDict().Add(propertyName, value);
        }

        [Fact]
        public void Add_WhenThrow()
        {
            string propertyName = "name";
            object? value = null;
            var nameDict = new NameDict();
            nameDict.Add(propertyName, value);
            Assert.Throws<ArgumentException>(() => nameDict.Add(propertyName, value));
        }
    }
}