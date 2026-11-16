 {

     int total = 0;
     Console.WriteLine("Digite quantos produtos você comprou");
     int qtdcompras = Convert.ToInt32(Console.ReadLine());
     for (int i = 0; i < qtdcompras; i++)
     {
         Console.WriteLine("Digite o valor do produto");
         int valorcompra = Convert.ToInt32(Console.ReadLine());

         total = total + valorcompra;
     }
     Console.WriteLine("O total ficou " + total);
 }
