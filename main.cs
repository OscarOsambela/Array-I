using System;

//estructura de datos que contiene valores del mismo tipo
//sirve para almacenar valores que normalmente tienen alguna relacion entre si

class MainClass {
  public static void Main (string[] args) {
    //cuando no conoces los valores[4]
    int[] edades;
    edades = new int[4];
    //ejemplo de valores ingresados dinamicamente
    edades[0] = 15;
    edades[1] = 25;
    edades[2] = 35;
    edades[3] = -15;
    Console.WriteLine(edades[3]);

    //cuando conoces los valores del array
    //ejemplo de valores ingresados por el mismo programador conociendo los valores como defininidos
    string[] nombres = { "Vernita", "Valentino", "Francisco", "Thelma"};
    Console.WriteLine(nombres[0]);
 
  }
}