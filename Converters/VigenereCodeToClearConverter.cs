﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Vigenere.Converters
{
    public class VigenereCodeToClearConverter : IMultiValueConverter
    {

        private string aLPH = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string ALPH { get => aLPH; set => aLPH = value; }

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
                    string clear = decode(inp, pass);
                    return clear;
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

        public string decode(string inp, string pass)
        {

            inp = inp.ToUpper();
            string passw = pass.ToUpper();
            string passwLen = "";

            while (passwLen.Length < inp.Length)
            {
                passwLen += passw;
            }

            string clear = "";

            for (int i = 0; i < inp.Length; i++)
            {
                int c = ALPH.IndexOf(passwLen[i]);
                int t = ALPH.IndexOf(inp[i]);

                if (c == -1 || t == -1)
                    return "INVALID INPUT";

                int index = t - c;

                if (index < 0)
                    index += 26;

                clear += ALPH[index];
            }

            return clear;

        }

    }
}
