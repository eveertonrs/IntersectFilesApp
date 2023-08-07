using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IntersectFilesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo1, arquivo2, arquivoSaida;

            Console.WriteLine("Informe o caminho completo para o primeiro arquivo:");
            arquivo1 = Console.ReadLine();

            Console.WriteLine("Informe o caminho completo para o segundo arquivo:");
            arquivo2 = Console.ReadLine();

            Console.WriteLine("Informe o caminho completo para o arquivo de saída:");
            arquivoSaida = Console.ReadLine();

            try
            {
                string[] linhasArquivo1 = File.ReadAllLines(arquivo1);
                string[] linhasArquivo2 = File.ReadAllLines(arquivo2);

                IEnumerable<string> intersecao = linhasArquivo1.Intersect(linhasArquivo2);

                File.WriteAllLines(arquivoSaida, intersecao);

                Console.WriteLine("Interseção de arquivos concluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
