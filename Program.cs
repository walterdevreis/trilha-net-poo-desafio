using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Marca: Nokia.");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Nokia 5530 Xpress Music", imei: "456123", memoria: 512);
nokia.Ligar();
nokia.InstalarAplicativo("YouTube Music");

Console.WriteLine("\n");

Console.WriteLine("Marca: iPhone.");
Smartphone iphone = new Iphone(numero: "9874", modelo: "iPhone 11", imei: "654789", memoria: 1024);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Nubank");