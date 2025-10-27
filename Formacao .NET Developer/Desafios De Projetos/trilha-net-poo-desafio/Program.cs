using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Nokia...");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nTestando Iphone...");
Smartphone iphone = new Iphone("987654321", "Iphone 12", "987654321", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");