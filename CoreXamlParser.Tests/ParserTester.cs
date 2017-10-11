using System;
using Xunit;
using CoreXamlParser;

namespace CoreXamlParser.Tests
{
    public class ParserTester
    {
        [Fact]
        public void ParserIsNotNull()
        {
            var parser = new CoreXmlParser.CoreXmlParser();

            Assert.NotNull(parser);
        }

        [Fact]
        public void ParserAcceptsString()
        {
            string xml = "<xml><\\xml>";

            var parser = new CoreXmlParser.CoreXmlParser(xml);

            Assert.NotNull(parser);
        }

        
        [Fact]
        public void ParserReturnsString()
        {
            string xml = "<xml><\\xml>";
            var parser = new CoreXmlParser.CoreXmlParser(xml);
            
            var expected = parser.ContentToParse; 

            Assert.Equal(xml, expected);
        }
    }
}
