using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Instruction_Set
{
    class Program
    {
        static void Main()
        {
            string opCode = Console.ReadLine();

            while (opCode != "END")
            {

                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = operandOne + 1;
                            break;
                        }
                    case "DEC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = operandOne - 1;
                            break;
                        }
                    case "ADD":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = int.Parse(codeArgs[1]);
                            long operandTwo = int.Parse(codeArgs[2]);
                            result = (long)(operandOne * operandTwo);
                            break;
                        }
                }

                Console.WriteLine(result);
                opCode = Console.ReadLine();
            }
        }
    }
}
