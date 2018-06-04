namespace CodeGenerator.Interfaces
{
    public interface ICodeConfiguration
    {
        void SetPattern(string pattern);
        void SetLength(int length);
        void SetStartingFrom(string startingFrom);
        void SetIsAutoincrement(bool isAutoincrement);
        void SetCharacters(string characteres);
        string GetPattern();
        int GetLength();
        string GetStartingFrom();
        bool GetIsAutoincrement();
        string GetCharacters();
    }
}
