using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    string continuar="S", marca;
    double consumo;
    Carro aut = new Carro("TESTE", 0);
    List<Carro> listaCarros = new List<Carro>();
   /*  try
    {
     int[] arr = new int[] { 4, 5, 8 };
     Console.WriteLine(arr[8]);
    }
   catch(Exception e)
   {
    Console.WriteLine("Ocorreu um erro");
    /* Tambem é possivel perdir mostrar o erro especifico usando nesse caso "e"."Message". 
   Console.WriteLine(e.Message);}*/
            


    while (continuar=="S"){
      try{
      Console.WriteLine("MARCA DO CARRO >>");
      marca = Console.ReadLine();
      Console.WriteLine("KM/L DO CARRO >>");
      consumo = double.Parse(Console.ReadLine());
      aut = new Carro(marca, consumo);
      listaCarros.Add(aut);
      Console.WriteLine("CONTINUAR? S/N");
      continuar = Console.ReadLine();
    }
    
    catch(System.FormatException){
       Console.WriteLine("Você Escreveu Errado");
     }}

    Carro menor_consumo = listaCarros[0];

    for(int i=1;i<listaCarros.Count;i++){
      if(listaCarros[i].getConsumo() > menor_consumo.getConsumo())
        menor_consumo = listaCarros[i];
    }
    Console.WriteLine("MARCA DE MENOR CONSUMO: {0} \n CONSUMO DE: {1} KM/L", menor_consumo.getMarca(), menor_consumo.getConsumo());

    for(int i=0;i<listaCarros.Count;i++){
      Console.WriteLine("-------------{0}------------", listaCarros[i].getMarca());
      Console.WriteLine("LITROS GASTOS EM 1000 KM: {0}", 1000/listaCarros[i].getConsumo());
      Console.WriteLine("VALOR GASTO AO PERCORRER 1000 KM {0}", (1000/listaCarros[i].getConsumo())*4.89);    
    }

  }
}