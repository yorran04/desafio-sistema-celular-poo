using Sistema_celular_poo.Models;

Console.WriteLine("SmartPhone Nokia: ");
SmartPhone nokia = new Nokia(numero: "1234", modelo: "AX2055", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalandoApp(nomeApp: "whatsapp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone");
SmartPhone iphone = new Iphone(numero: "145688", modelo: "iphone6", imei: "22222", memoria: 84);
iphone.Ligar();
iphone.RecebendoLigacao();
iphone.InstalandoApp(nomeApp: "instagram");
