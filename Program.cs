using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("=== Testando Nokia ===");
Smartphone nokia = new Nokia("XX X XXXX-XXXX", "Nokia Tijolão", "123456789", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n=== Testando iPhone ===");
Smartphone iphone = new Iphone("XX X XXXX-XXXX", "iPhone 15 Pro", "987654321", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\nTestes finalizados!");
