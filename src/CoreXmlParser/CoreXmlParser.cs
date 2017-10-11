using System;

namespace CoreXmlParser
{
    public class CoreXmlParser
    {
        public readonly string _content;

        public string ContentToParse => this._content;
        public CoreXmlParser()
        {
            
        }

        public CoreXmlParser(string contentToParse)
        {
            _content = contentToParse;
        }
    }

    public class Node 
    {
        public NodeList Children { get; set; }

        public NodeAttributeList NodeAttributeList {get;set;}
    }

    public class NodeAttributeList
    {
        public NodeAttribute Current { get; set; }
    }

    public class NodeAttribute 
    {

    }

    public class NodeList
    {

    }
}
