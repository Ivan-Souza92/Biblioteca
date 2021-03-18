using CadastroLivro.Classes;
using System;

namespace CadastroLivro
{
    class Program
    {
		static LivroRepositorio repositorio = new LivroRepositorio();
		static ClienteRepositorio clienteR = new ClienteRepositorio();
		static EmprestimoRepositorio emprestimoR = new EmprestimoRepositorio();
		static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						InserirLivro();
						break;
					case "2":
						ListarLivros();
						break;
					case "3":
						AtualizarLivro();
						break;
					case "4":
						ExcluirLivro();
						break;
					case "5":
						VisualizarLivro();
						break;
					case "6":
						CadastrarCliente();
						break;
					case "7":
						RealizarEmprestimo();
						break;
					case "8":
						VisualizarEmprestimos();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

		}


		private static void VisualizarEmprestimos()
		{
			Console.WriteLine("Lista de Empréstimos ");
			var lista = emprestimoR.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Não foi realizado empréstimos até o momento.\n");
				return;
			}

			foreach (var emprestimo in lista)
			{
				Console.WriteLine(emprestimo.ToString());
			}


		}


		private static void RealizarEmprestimo()
        {
			Console.WriteLine("Empréstimo de livro");

			var lista = repositorio.Lista();
			var listaCliente = clienteR.Lista();
			Livro livro = new Livro();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum livro cadastrado.");
				return;
			}

			ListarLivros();

			Console.Write("\nDigite o id do Livro de acordo com a lista acima: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			if(listaCliente.Count == 0)
            {
				Console.WriteLine("Não há clientes cadastrado");
				return;
            }
			ListarClientes();
	
			Console.WriteLine("\nDigite o id do cliente de acordo com a lista acima");
			int indiceCliente = int.Parse(Console.ReadLine());

			Console.WriteLine("Dia do empréstimo: ");
			int entradaDia = int.Parse(Console.ReadLine());

			Console.WriteLine("Mês do empréstimo: ");
			int entradaMes = int.Parse(Console.ReadLine());

			Console.WriteLine("Ano do empréstimo: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.WriteLine("Hora do empréstimo (exemplo: 09): ");
			int entradaHora = int.Parse(Console.ReadLine());

			Console.WriteLine("minuto (exemplo: 10): ");
			int entradaMinutos = int.Parse(Console.ReadLine());

			Console.WriteLine("segundos: ");
			int entradaSegundos = int.Parse(Console.ReadLine());

			repositorio.Emprestimo(indiceLivro);

			Emprestimo emprestimo = new Emprestimo(id: emprestimoR.ProximoID(), idCliente: indiceCliente, idLivro: indiceLivro, dia: entradaDia, mes: entradaMes, ano: entradaAno,hour:entradaHora ,minutes:entradaMinutos,seconds: entradaSegundos);

			emprestimoR.Insere(emprestimo);
		}

		private static void ListarClientes()
		{
			Console.WriteLine("Lista de Clientes ");

			var lista = clienteR.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Não há clientes cadastrados\n");
				return;
			}
			foreach (var cliente in lista)
			{
				Console.WriteLine("#ID {0}: - {1}", cliente.retornaId(), cliente.RetornaNome());
			}
		}


		private static void CadastrarCliente()
        {
			Console.WriteLine("Cadastro do Cliente");

			foreach (int i in Enum.GetValues(typeof(Sexo)))
			{
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Sexo), i));
			}

			Console.WriteLine("Digite o sexo de acordo a numeração acima: ");
			int entradaSexo = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite o nome do cliente: ");
			string nomeCliente = Console.ReadLine();

			Console.WriteLine("Digite o cpf do cliente: ");
			string entradaCpf = Console.ReadLine();

			Console.WriteLine("Digite o endereco do cliente: ");
			string entradaEndereco = Console.ReadLine();

			Console.WriteLine("Digite o telefone: ");
			string entradaTelefone = Console.ReadLine();

			Cliente cliente = new Cliente(id: clienteR.ProximoId(),nome:nomeCliente, sexo: (Sexo)entradaSexo, cpf:entradaCpf , endereco:entradaEndereco ,telefone:entradaTelefone );

			clienteR.Insere(cliente);
		}

		private static void VisualizarLivro()
		{
			Console.Write("Digite o id do Livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceLivro);

			Console.WriteLine(serie);
		}

		private static void ExcluirLivro()
		{
			Console.Write("Digite o id do livro: ");

			int indiceLivro = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceLivro);
		}

		private static void AtualizarLivro()
		{
			Console.Write("Digite o id do livro: ");
			int idLivro = int.Parse(Console.ReadLine());


			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int Opcaogenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do Livro: ");
			string nomeLivro = Console.ReadLine();

			Console.WriteLine("Digite o ano do livro: ");
			int anoLivro = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite o nome do autor do livro; ");
			string nomeAutor = Console.ReadLine();

			Console.WriteLine("Digite o número da edição: ");
			int numEdicao = int.Parse(Console.ReadLine());

			Livro atualizaLivro = new Livro(id: repositorio.ProximoID(), exemplar: nomeLivro, genero: (Genero)Opcaogenero, autor: nomeAutor, edicao: numEdicao, ano: anoLivro);


			repositorio.Atualiza(idLivro, atualizaLivro);
		}

		private static void InserirLivro()
        {
			Console.WriteLine("Cadastro de Livro");

			foreach(int i in Enum.GetValues(typeof(Genero)))
            {
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

			Console.WriteLine("Digite o genêro entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite o nome do livro: ");
			string nomeExemplar = Console.ReadLine();

			Console.WriteLine("Digite o ano do livro: ");
			int anoLivro = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite o nome do autor do livro; ");
			string nomeAutor = Console.ReadLine();

			Console.WriteLine("Digite o número da edição: ");
			int numEdicao = int.Parse(Console.ReadLine());

			Livro livro = new Livro(id: repositorio.ProximoID(), exemplar: nomeExemplar, genero: (Genero)entradaGenero , autor: nomeAutor, edicao: numEdicao, ano: anoLivro);

			repositorio.Insere(livro);
		}

		private static void ListarLivros()
        {
			Console.WriteLine("Lista de Livros ");

			var lista = repositorio.Lista();

			if(lista.Count == 0 )
            {
				Console.WriteLine("Não há livros cadastrados\n");
				return;
            }
			foreach(var livros in lista)
            {
				Console.WriteLine("#ID {0}: - {1}", livros.retornaId(), livros.ExemplarName());
            }
        }

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Cadastro de Livros, Sejam Bem Vindos ! ");
			Console.WriteLine("Informe a opção desejada: ");

			Console.WriteLine("1- Cadastrar Livro");
			Console.WriteLine("2- Listar Livros");
			Console.WriteLine("3- Atualizar Livro");
			Console.WriteLine("4- Excluir Livro");
			Console.WriteLine("5- visualizar Livro");
			Console.WriteLine("6- Cadastrar o cliente");
			Console.WriteLine("7- Realizar Empréstimo de Livro");
			Console.WriteLine("8- Visualizar Empréstimos");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}
