using System;

namespace OperatorsExpressionsStatements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Statements = complete thoughts, made up of one or more expressions
            // Expressions - made up of operators and operins 
            // Expression example: Console.WriteLine("Hello World!");
            // Operins: objects, variables, classes, literal strings
            // Operators: + (string contatination and math), =, ==, (), .


            int x, y, a, b;
            // Easy way to declare several variables in one line

            // Assignment Operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // There are many mathematical operators...

            // Additon Operator
            x = 3 + 4;

            // Subtration Operator
            x = 4 - 3;

            // Multiplication Operator
            x = 10 * 5;

            // Divison Operator
            x = 10 / 5;


            // There are many operators used to evaluate values...

            // Equality Operator
            if (x == y)
            {
            }

            // Greater Than Operator
            if (x > y)
            {
            }

            // Less Than Operator
            if (x < y)
            {
            }

            // Greater Than or Equal To Operator
            if (x >= y)
            {
            }

            // Less Than or Equal To Operator
            if (x <= y)
            {
            }


            // There are two "conditional" operators as well that can be used to expand
            // or enhance an evaluation ... and they can be combined together multiple times.

            // Conditional AND Operator (BOTH TRUE)
            if ((x > y) && (a > b))
            {
            }

            // Conditional OR Operator (EITHER TRUE)
            if ((x > y) || (a > b))
            {
            }


            // Also, here's the in-line conditional operator 
            string message = (x == 1) ? "Car" : "Boat";
            // ? to see if it is equal, then set it to "Car", otherwise, it's "Boat"

            // Member Access and Method Invocation
            Console.WriteLine("Hi");



            // Declaration Statement: int x;
            // Expression Statement: myString = myFirstName + myLastName;
            // In each case, the expression is evaluated, then assigned
            // Decision Statements: if (x > y)z = "Bob";
            // New lines/whitespace are only there for our readability

            // Syntax is important for understanding

            x + y;
            // Need for property formed statement



            // Statements are complete instructions in C# (sentence)
                // They consist of expressions (nouns and verbs)
                    // Made up of operins and operators
                    // Operin = object, variable, literal string
                    // Operators = act on the operin

        }
    }
}
