﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Vigenere.Converters
{
    public class VigenereClearToCodeConverter : IMultiValueConverter
    {
        private string aLPH = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string ALPH { get => aLPH; set => aLPH = value; }

        private char[] keepChars = { ' ', '.', ',', '!', '?' };
        public char[] KeepChars { get => keepChars; set => keepChars = value; }


        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) 
        {
            try
            {
                string inp = (string)values[0];
                string pass = (string)values[1];
                if (String.IsNullOrEmpty(inp) || String.IsNullOrEmpty(pass))
                    return "";
                else
                {
                    string code = encode(inp, pass);
                    return code;
                }

            }
            catch (Exception)
            {
                return "ERROR";
            }

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public string encode(string inp, string pass)
        {

            inp = inp.ToUpper();
            string passw = pass.ToUpper();
            string passwLen = "";

            while (passwLen.Length< inp.Length)
            {
                passwLen += passw;
            }

            string code = "";

            for (int i = 0; i < inp.Length; i++)
            {
                int c = ALPH.IndexOf(passwLen[i]);
                int t = ALPH.IndexOf(inp[i]);

                if (Array.Exists(KeepChars, element => element == inp[i]))
                {
                    // keep spaces/signs from the input for the output
                    code += inp[i];
                    continue;
                }

                if (c == -1)
                    return "INVALID INPUT: '" + passwLen[i] + "'";
                if (t == -1)
                    return "INVALID INPUT: '" + inp[i] + "'";

                int index = t + c;

                if (index >= 26)
                    index -= 26;
                
                code += ALPH[index];
            }

            return code;

        }

    }

}