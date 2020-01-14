﻿using System;
using System.IO;
using System.Threading.Tasks;

namespace Unmango.Xml
{
    public class XmlTextReader : TextReader
    {
        private readonly XmlReader _reader;

        public XmlTextReader(ref XmlReader reader)
        {
            _reader = reader;
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj) => _reader.Equals(obj);

        public override int GetHashCode() => _reader.GetHashCode();

        public override object InitializeLifetimeService()
        {
            throw new NotImplementedException();
        }

        public override int Peek()
        {
            throw new NotImplementedException();
        }

        public override int Read()
        {
            throw new NotImplementedException();
        }

        public override int Read(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public override Task<int> ReadAsync(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public override int ReadBlock(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public override Task<int> ReadBlockAsync(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public override string ReadLine()
        {
            throw new NotImplementedException();
        }

        public override Task<string> ReadLineAsync()
        {
            throw new NotImplementedException();
        }

        public override string ReadToEnd()
        {
            throw new NotImplementedException();
        }

        public override Task<string> ReadToEndAsync()
        {
            throw new NotImplementedException();
        }

        public override string ToString() => _reader.ToString();

        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
    }
}
