using Celular_Csharp.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo: "Modelo 1", memoria: 500, imei: "11111111111111");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "12345", modelo: "15 ProMax", imei: "1132321212221111", memoria: 250);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
