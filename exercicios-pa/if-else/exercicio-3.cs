Console.WriteLine("Qual o código de origem do produto?");

int codigo = Convert.ToInt32(Console.ReadLine());

if (codigo == 1)

{

Console.WriteLine("A procedência do produto é do Sul");

}

else if ( codigo == 2)

{

Console.WriteLine("A procedência do produto é do Norte");

}

else if (codigo == 3)

{

Console.WriteLine("A procedência do produto é do Leste");

}

else if (codigo == 4)

{

Console.WriteLine("A procedência do produto é do Oeste");

}

else

{

Console.WriteLine("O produto é importado");

} 
