using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class _01_Balanced
    {
		/*
		You're working with an intern that keeps coming to you with JavaScript code that won't run because the braces, brackets, and parentheses are off. To save you both some time, you decide to write a braces/brackets/parentheses validator. 
		Let's say: 
		'(', '{', '[' are called "openers." 
		')', '}', ']' are called "closers." 
		Write an efficient function that tells us whether or not an input string's openers and closers are properly nested. 
		Examples: 
		"{ [ ] ( ) }" should return true 
		"{ [ ( ] ) }" should return false 
		"{ [ }" should return false 
		*/

        private Dictionary<string, string> closers = new Dictionary<string, string>() {
                { "{", "}" },
                { "(", ")" },
                { "[", "]" }
            };

        public bool EstaBalanceado(string cadena)
        {


            if (string.IsNullOrWhiteSpace(cadena))
            {
                return false;
            }

            if (cadena.Length % 2 != 0)
            {
                return false;
            }

            if (!(cadena[0].ToString() == "{" && cadena[cadena.Length - 1].ToString() == "}"))
            {
                return false;
            }

            for (int i = 1; i < cadena.Length - 1; i = i + 2)
            {
                var c1 = cadena[i].ToString();
                var c2 = cadena[i + 1].ToString();

                if (c2 != closers[c1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
