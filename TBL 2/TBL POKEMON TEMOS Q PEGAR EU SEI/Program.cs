using PokemonAPI.Services;

var service = new PokemonService();

while (true)
{
    Console.WriteLine("============================");
    Console.WriteLine("  POKEMON FINDER");
    Console.WriteLine("============================");
    Console.WriteLine("1 - Buscar por nome");
    Console.WriteLine("2 - Pokemon aleatorio");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");

    var opcao = Console.ReadLine();

    if (opcao == "0")
        break;

    if (opcao == "1")
    {
        Console.Write("Digite o nome do pokemon: ");
        var nome = Console.ReadLine();

        var pokemon = await service.BuscarPokemon(nome);

        if (pokemon == null)
        {
            Console.WriteLine("Pokemon nao encontrado!");
        }
        else
        {
            ExibirPokemon(pokemon);
        }
    }
    else if (opcao == "2")
    {
        Console.WriteLine("Buscando pokemon aleatorio...");
        var pokemon = await service.BuscarPokemonAleatorio();

        if (pokemon == null)
        {
            Console.WriteLine("Erro ao buscar pokemon!");
        }
        else
        {
            ExibirPokemon(pokemon);
        }
    }

    Console.WriteLine();
}

void ExibirPokemon(PokemonAPI.Models.Pokemon pokemon)
{
    Console.WriteLine();
    Console.WriteLine("Pokemon encontrado!");
    Console.WriteLine($"ID: {pokemon.Id}");
    Console.WriteLine($"Nome: {pokemon.Name}");
    Console.WriteLine($"Altura: {pokemon.Height}");
    Console.WriteLine($"Peso: {pokemon.Weight}");
    Console.WriteLine($"Base Experience: {pokemon.BaseExperience}");

    var tipos = string.Join(", ", pokemon.Types.Select(t => t.Type.Name));
    Console.WriteLine($"Tipos: {tipos}");
}
