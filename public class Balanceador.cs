public class Balanceador
{
    public static bool EsBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0 || !SonPareja(pila.Pop(), c))
                {
                    return false;
                }
            }
        }

        return pila.Count == 0;
    }

    private static bool SonPareja(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }
}

