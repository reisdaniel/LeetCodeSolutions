namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um problema para executar:");

            var choice = Console.ReadLine();

            try
            {
                var result = choice 
                switch
                {
                    // Aqui vou adicionar os casos dos desafios
                    _ => "Nenhum problema selecionado. Por favor, escolha uma opção válida."
                };

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        static string RunSolution(Func<string> solution)
        {
            return solution();
        }
    }
}
