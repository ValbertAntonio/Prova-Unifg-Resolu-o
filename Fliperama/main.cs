using System;

class ControleDoTempo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao fliperama, digite quantas fases fáceis tem no jogo: ");
        int faseFacil = Convert.ToInt32(Console.ReadLine());

        if (faseFacil > 96)
        {
            Console.WriteLine("Digite um número de fases menor ou igual a 96: ");
            int faseCerta = Convert.ToInt32(Console.ReadLine());
            faseFacil = faseCerta;
        }

        int faseDificil = 96 - faseFacil;
        int horasFaseFacil = faseFacil;
        int horasFaseDificil = faseDificil * 2;
        int dinheiroGasto = (horasFaseDificil + horasFaseFacil) * 5;

        Console.WriteLine("Quantidade de fases fáceis: " + faseFacil);
        Console.WriteLine("Quantidade fases difíceis: " + faseDificil);
        Console.WriteLine("Horas nas fases fáceis: " + horasFaseFacil);
        Console.WriteLine("Horas nas fases difíceis: " + horasFaseDificil);
        Console.WriteLine("Total de horas gastas até concluir o jogo: " + (horasFaseFacil + horasFaseDificil));
        Console.WriteLine("Valor em reais da jogatina: R$" + dinheiroGasto + ",00");
        
        
    }
}
