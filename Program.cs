using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "56565656", modelo: "Modelo 1", imei: "707070700", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("FUTEBOL");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "56565656", modelo: "Modelo 1", imei: "707070700", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Esport");

// TODO: Realizar os testes com as classes Nokia e Iphone