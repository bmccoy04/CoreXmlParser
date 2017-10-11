using System;

namespace CoreXmlParser
{
    public class CoreXmlParser
    {
        public readonly string _content;

        public string ContentToParse { get { return this._content; } }
        public CoreXmlParser()
        {
            
        }

        public CoreXmlParser(string contentToParse)
        {
            _content = contentToParse;
        }
    }
}
