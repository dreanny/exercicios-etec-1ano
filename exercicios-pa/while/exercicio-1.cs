{
    int numero = 1;
    int soma = 0;

    while (numero != 0)
    {

        Console.WriteLine("Digite um número:");
      numero = Convert.ToInt32  (Console.ReadLine());

        soma = soma + numero;

    }
                Console.WriteLine("A soma foi " + soma);

}
