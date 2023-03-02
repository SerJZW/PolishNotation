using System;
using System.Collections.Generic;


namespace PolishNotation
{
    class Calculator
    {
        
        public void calculator()
        {
            string arg;
            Stack<double> st = new Stack<double>();
            Console.WriteLine("Введите 2 числа и оператор через Enter: \nДля выхода введите exit");
            while ((arg = Console.ReadLine()) != "exit") // Программа не закончит работу пока не написан exit
            {

                double number;
                bool isNum = double.TryParse(arg, out number);
                if (isNum)
                    st.Push(number);
                else
                {
                    double op2;
                    switch (arg)
                    {
                        case "+":
                            GetPriority(arg);
                            st.Push(st.Pop() + st.Pop());
                            break;
                        case "*":
                            GetPriority(arg);
                            op2 = st.Pop();
                            if (op2 != 0.0)
                            {
                                st.Push(st.Pop() * op2);
                            }
                            else
                            {
                                st.Push(st.Pop() * 0);
                            }
                            break;
                        case "-":
                            GetPriority(arg);
                            op2 = st.Pop();
                            st.Push(st.Pop() - op2);
                            break;
                        case "/":
                            GetPriority(arg);
                            op2 = st.Pop();
                            if (op2 != 0.0)
                                st.Push(st.Pop() / op2);
                            else
                                Console.WriteLine("Ошибка. Деление на ноль");
                            break;
                        case "Результат":
                            Console.WriteLine("Результат: " + st.Pop()); // Вывод результата
                            break;
                        case "(":
                            GetPriority(arg);
                            break;
                        case ")":
                            GetPriority(arg);
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                }
            }
        }
        public byte GetPriority(string arg)
        {
            switch (arg)
            {
                case "(": return 0;
                case ")": return 1;
                case "+": return 2;
                case "-": return 3;
                case "*": return 4;
                case "/": return 4;
                case "^": return 5;
                default: return 6;
            }
        }
    }
}