using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifreleme
{
    public class Helper
    {
        private char NumberToChar(int number)
        {
            return (char)number;
        }

        private int CharToNumber(char _char)
        {
            return (int)_char;
        }

        public string EncryptText(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (result.Length > 0)
                {
                    result = result + ';';
                }
                result = result + CharToNumber(text[i]);
            }
            return result;
        }

        public string DecryptText(string text)
        {
            string result = "";
            string[] _chars = text.Split(';');
            foreach (var _char in _chars)
            {
                result = result + NumberToChar(int.Parse(_char));
            }
            return result;
        }
    }
}
