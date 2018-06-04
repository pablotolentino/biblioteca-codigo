using CodeGenerator.Interfaces;
using System;
using System.Resources;

namespace CodeGenerator.CodeAleatory
{
    public class Aleatory : IAleatory
    {
        #region  campos privados
        private string _code;
        private ICodeConfiguration _codeConfiguration;
        private bool _isValidConfig;
        private string _possibles = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
        ResourceManager _rm = CodeGenerator.CodeAleatory.Properties.Resources.ResourceManager;
        #endregion
        #region contructor  
        public Aleatory()
        {

        }
        #endregion

        #region Métodos publicos
        public string Generate(ICodeConfiguration codeConfiguration)
        {
            _codeConfiguration = codeConfiguration;
            if (!isValidConfiguration())
            {
                return _code;
            }

            Random obj = new Random();

            int length = _possibles.Length;
            char letter;
            int lengthnewstring = codeConfiguration.GetLength();
            for (int i = 0; i < lengthnewstring; i++)
            {
                letter = _possibles[obj.Next(length)];
                _code += letter.ToString();
            }            

            return _code;
        }
        #endregion

        #region metodo privados
        private bool isValidConfiguration()
        {
            if (_codeConfiguration.GetLength() == 0)
            {
                _isValidConfig = false;   
                throw new Exception(_rm.GetString("MissingDefineCodeLength"));
            }
            _isValidConfig = true;
            return _isValidConfig;
        }
        #endregion
    }
}
