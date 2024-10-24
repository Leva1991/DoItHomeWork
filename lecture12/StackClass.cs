using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lecture12
{
    internal class StackClass
    {
        public static bool CheckBalanceOfParentheses(string argument)
        {
            int countLeftParenth(string argument) 
            {
                int count = 0;
                for(int i = 0; i < argument.Length; i++)
                {
                    if (argument[i] == '(')
                    {
                        count++;
                    }
                }
                return count;
            }

            int countRightParenth(string argument)
            {
                int count = 0;
                for (int i = 0; i < argument.Length; i++)
                {
                    if (argument[i] == ')')
                    {
                        count++;
                    }
                }
                return count;
            }

            if (countLeftParenth(argument).Equals(countRightParenth(argument))){
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
