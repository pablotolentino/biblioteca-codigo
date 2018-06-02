using CodeGenerator.Interfaces;
using System;

namespace CodeGenerator.CodeConfiguration
{
    public class Configuration : ICodeConfiguration
    {
        private string _characteres;
        public Configuration()
        {

        }
        public void SetCharacters(string characteres)
        {
            throw new NotImplementedException();
        }

        public void SetIsAutoincrement(bool isAutoincrement)
        {
            throw new NotImplementedException();
        }

        public void SetLength(int length)
        {
            throw new NotImplementedException();
        }

        public void SetPattern(string pattern)
        {
            throw new NotImplementedException();
        }

        public void SetStartingFrom(string startingFrom)
        {
            throw new NotImplementedException();
        }
    }
}
