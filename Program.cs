String letra, palavra;

Console.WriteLine("Digite a palavra do jogo");
palavra = Console.ReadLine();

Console.WriteLine("Digite uma letra: ");
letra = Console.ReadLine();


if(palavra.IndexOf(letra) >= 0){
    Console.Write("Acertou! A letra digitada existe na palavra.");
}else{
    Console.Write("Errou! A letra digitada não existe na palavra.");
}

