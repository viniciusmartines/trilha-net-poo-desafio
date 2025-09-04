using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia n1 = new Nokia(numero: "1199845-0987", modelo: "Nokia1000", imei: "012345679111111", 32);
n1.InstalarAplicativo("Whatsapp");
n1.Ligar();

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Iphone p1 = new Iphone("1193454-3453", "Iphone 15 Pro Max", "111111111111111", 256);
p1.InstalarAplicativo("Facebook");
p1.ReceberLigacao();