using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone Nokia:");
var iphone = new Iphone(numero: "123", modelo: "X", imei: "5789452", memoria: 8);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone:");
var nokia = new Nokia(numero: "2548", modelo: "Nokia 20", imei: "54878652", memoria: 4);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");