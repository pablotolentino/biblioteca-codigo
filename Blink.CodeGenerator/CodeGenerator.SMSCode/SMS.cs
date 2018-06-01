using CodeGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGenerator.SMSCode
{
    public class SMS : ICode
    {
        private string _characteres;
        private bool _isAutoincrement;
        private int _length;
        private string _pattern;
        private string _startingFrom;
        public string Generate()
        {
            throw new NotImplementedException();
        }

        #region "Configuración"

        #endregion
        public void SetCharacters(string characteres)
        {
            _characteres = characteres;
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
