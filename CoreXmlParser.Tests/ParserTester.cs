using System;
using Xunit;
using CoreXmlParser;

namespace CoreXmlParser.Tests
{
    public class ParserTester
    {
        [Fact]
        public void ParserIsNotNull()
        {
            var parser = new CoreXmlParser();

            Assert.NotNull(parser);
        }

        [Fact]
        public void ParserAcceptsString()
        {
            string xml = "<xml><\\xml>";

            var parser = new CoreXmlParser(xml);

            Assert.NotNull(parser);
        }

        
        [Fact]
        public void ParserReturnsString()
        {
            string xml = "<xml><\\xml>";
            var parser = new CoreXmlParser(xml);
            
            var expected = parser.ContentToParse; 

            Assert.Equal(xml, expected);
        }
    }
}
