using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smatphone Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 2020", imei: "00000000", memoria: 70);
nokia.Ligar();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine("------------------------");

Console.WriteLine("Smatphone Iphone");
Smartphone iphone = new Iphone(numero: "67890", modelo: "Modelo 2024", imei: "11111111", memoria: 75);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

