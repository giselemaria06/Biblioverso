namespace Biblioverso.Data
{
    public class LivroRepoaitory
    {
        private static List<Livro> _tabelaLivros =new List<Livro>();

        private static  int proximoId = 1; // Variável auxiliar 

        public void Adicionar(Livro livro) // método: adiciona livros na lista
        {
            livro.Id = proximoId++; 
            _tabelaLivros.Add(livro);
        }

    }
}
