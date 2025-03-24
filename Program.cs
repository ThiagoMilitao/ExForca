String letra, palavra;

Console.WriteLine("Digite a palavra do jogo");
palavra = Console.ReadLine().ToLower();

Console.WriteLine("Digite uma letra: ");
letra = Console.ReadLine().ToLower()  ;

Console.WriteLine($"A letra {letra} existe na palavra secreta?  => {palavra.Contains(letra)}");

