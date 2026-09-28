using Biblioverso.Business;
using Biblioverso.Models;

namespace Biblioverso.Business
{
    // A BLL contém as REGRAS DE NEGÓCIO e validações
    public class LivroService_esqueleto
    {
        private LivroRepository _repository = new LivroRepository();

        public bool CadastrarLivro(string titulo, string autor, out string mensagemErro)
        {

            // Regra de Negócio 1: Campos obrigatórios
            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor))
            {
                //vamos contruir esse bloco de código para validar os campos obrigatórios
                mensagemErro = "Título e Autor são obrigratórios!";
                return false;
            }

            // Regra de Negócio 2: Título precisa ter pelo menos 3 caracteres
            if (titulo.Length < 3)
            {
                //vamos contruir esse bloco de código para validar o comprimento do título
                mensagemErro = "O título do livro deve ter no máximo 3 caracteres"
            }

            //CRIANDO UM NOVO OBJETO LIVRO E ADICIONANDO AO REPOSITÓRIO
            Livro novoLivro = new Livro
            {
                //vamos contruir esse bloco de código para criar um novo livro e adicionar ao repositório
                Titulo = titulo,
                Autor = autor,
                Emprestado = false
            };
          
            _repository.Adicionar(novoLivro);
            mensagemErro = string.Empty;
            return true;
        }
        public List<Livro> ListarAcervo()
        {
            return _repository.ObterTodos();
        }

        // ====================================================================
        // NOVO MÉTODO 1: Buscar Livros por Autor (Uso do foreach e if)
        // ====================================================================
        
        public List<Livro> BuscarPorAutor(string autorBuscado)
        {
            List<Livro> todos = _repository.ObterTodos();
            List<Livro> resultado = new List<Livro>();

            // TODO (DESAFIO 1): Percorra a lista 'todos' usando 'foreach'.
            // Para cada livro, verifique se o Autor é igual ao 'autorBuscado'.
            // Se for igual, adicione na lista 'resultado'.

            /*
            foreach (var livro in todos)
            {
                if (livro.Autor == autorBuscado)
                {
                    resultado.Add(livro);
                }
            }
            */

            return resultado;
        }

        // ====================================================================
        // NOVO MÉTODO 2: Listar apenas Livros Disponíveis (Uso do foreach e if)
        // ====================================================================
        public List<Livro> ListarDisponiveis()
        {
            List<Livro> todos = _repository.ObterTodos();
            List<Livro> disponiveis = new List<Livro>();

            // TODO (DESAFIO 2): Percorra a lista 'todos' usando 'foreach'.
            // Adicione na lista 'disponiveis' apenas os livros onde Emprestado é igual a false.

            return disponiveis;
        }
    }
}