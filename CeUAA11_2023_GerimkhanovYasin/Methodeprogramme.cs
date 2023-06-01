using System;
using System.Collections.Generic;
using System.Text;

namespace CeUAA11_2023_GerimkhanovYasin
{
    
    public struct Methodeprogramme
    {
        public void CryptVigenere(string phClaire, string phClef, out string MatVigenere)
        {
            int codeAscii;
            int j;
            MatVigenere = new string[4, phClaire.Length];
            j = 0;
            for (int i = 0; i < phClaire.Length - 1; i++)
            {
                MatVigenere[0, i] = phClaire[i];
                if (j == phClef.Length)
                {
                    j = 0;
                }
                else
                {

                }
                MatVigenere[1, i] = phClef[j];
                MatVigenere[2, i] = ((int)phClef[j] - 65).ToString();
                if (((int)phClaire[i] + int.Parse(MatVigenere[2, i]) <= 90))
                {
                    codeAscii == (int)char.Parse(MatVigenere[0, i]) + int.Parse(MatVigenere[2, i]);
                }
                else
                {
                    codeAscii == (int)char.Parse(MatVigenere[0, i]) + int.Parse(MatVigenere[2, i]) - 26;
                }
                MatVigenere[3, i] = Convert.ToChar(codeAscii).ToString();
                j = j + 1;
            }


        }
        public void CryptAffine(string phClaire, int a, int b)
        {
            int x;
            int y;
            string[,] matAffine = new string[4, phClaire.Length];
            for (int i = 0; i < phClaire.Length - 1; i++)
            {
                matAffine[0, 1] = phClaire[i];
                x = ((int)phClaire[i] - 65);
                matAffine[1, i] = x;
                y = (a * x + b) % 26;
                matAffine[2, i] = y;
                matAffine[3, i] = y + 65;
            }
        }
    }
}
