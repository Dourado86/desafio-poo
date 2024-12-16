using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"123", modelo:"a10", imei:"456789", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"456", modelo:"a020", imei:"985478", memoria: 256);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsaap");
nokia.Ligar();