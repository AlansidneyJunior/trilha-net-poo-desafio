using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testando Smartphone Nokia:");
Smartphone nokia = new Nokia("1234", "A01", "ABC", 128);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("---------------------");


Console.WriteLine("Testando Smartphone Iphone:");
Smartphone iphone = new Iphone("4321", "10", "XYZ", 64);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");



