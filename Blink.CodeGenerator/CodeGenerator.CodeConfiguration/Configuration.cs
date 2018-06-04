using CodeGenerator.Interfaces;

namespace CodeGenerator.CodeConfiguration
{
    public class Configuration : ICodeConfiguration
    {
        private string _characteres;
        private bool _isAutoincrement;
        private int _length;
        private string _pattern;
        private string _startingFrom;
        public Configuration()
        {

        }

        public string GetCharacters()
        {
            return _characteres;
        }

        public bool GetIsAutoincrement()
        {
            return _isAutoincrement;
        }

        public int GetLength()
        {
            return _length;
        }

        public string GetPattern()
        {
            return _pattern;
        }

        public string GetStartingFrom()
        {
            return _startingFrom;
        }

        public void SetCharacters(string characteres)
        {
            this._characteres = characteres;
        }

        public void SetIsAutoincrement(bool isAutoincrement)
        {
            this._isAutoincrement = isAutoincrement;
        }

        public void SetLength(int length)
        {
            this._length = length;
        }

        public void SetPattern(string pattern)
        {
            this._pattern = pattern;
        }

        public void SetStartingFrom(string startingFrom)
        {
            this._startingFrom = startingFrom;
        }
    }
}
