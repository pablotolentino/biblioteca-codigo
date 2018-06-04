using CodeGenerator.Interfaces;
using System;
using System.Resources;
using System.Text.RegularExpressions;

namespace CodeGenerator.CodeAutoincrement
{
    public class Autoincrement : IAutoincrement
    {
        #region  campos privados
        private string _code;
        private ICodeConfiguration _codeConfiguration;
        private bool _isValidConfig;
        private string _charpattern = @"\D+";
        private string _decimalpattern = @"\d+";
        ResourceManager _rm = CodeGenerator.CodeAutoincrement.Properties.Resources.ResourceManager;

        #endregion

        #region Contructor
        public string Generate(ICodeConfiguration codeConfiguration)
        {
            _codeConfiguration = codeConfiguration;
            if (!isValidConfiguration())
            {
                return _code;
            }

            string startingfrom = _codeConfiguration.GetStartingFrom();


            if (!Regex.IsMatch(startingfrom, (_decimalpattern + "$")))
            {
                throw new Exception(_rm.GetString("AutoincrementCanNotBeApplied"));
            }

            string[] numbers = Regex.Split(startingfrom, _charpattern);

            if (numbers.Length == 0)
            {
                throw new Exception(_rm.GetString("AutoincrementCanNotBeApplied"));
            }

            string startnumber = numbers[numbers.Length - 1];
            Int64 nextnumber = 0;
            Int64 currentnumber = 0;
            currentnumber = int.Parse(numbers[numbers.Length - 1]);

            nextnumber = currentnumber + 1;
            _code = startingfrom.Replace(startnumber, nextnumber.ToString().PadLeft(startnumber.Length, '0'));
            return _code;
        }
        #endregion

        #region metodo privados
        private bool isValidConfiguration()
        { 
            if (string.IsNullOrEmpty(_codeConfiguration.GetStartingFrom()))
            {
                _isValidConfig = false;
                throw new Exception(_rm.GetString("MissingDefineStart"));
            }

            _isValidConfig = true;
            return _isValidConfig;
        }
        #endregion
    }
}
