public class TorresHanoi
{
    public static void Resolver(int n, Stack<int> origen, Stack<int> auxiliar, Stack<int> destino)
    {
        if (n == 1)
        {
            destino.Push(origen.Pop());
        }
        else
        {
            Resolver(n - 1, origen, destino, auxiliar);
            destino.Push(origen.Pop());
            Resolver(n - 1, auxiliar, origen, destino);
        }
    }
}