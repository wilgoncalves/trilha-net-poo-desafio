using System.ComponentModel;
using DesafioPOO.Models;

// IMPLEMENTADO!!!
Console.WriteLine("Smartphone NOKIA:");
Smartphone nokia = new Nokia(numero: "9999-2222", modelo: "XTQ-456", imei: "12589325", memoria: 126);
Console.WriteLine($"O numero do celular Nokia é {nokia.Numero}");
nokia.Ligar();
Console.WriteLine("O número se encontra ocupado!");
nokia.InstalarAplicativo("Snake Game");

Console.WriteLine("----------------------------");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "5555-6666", modelo: "FSJ-467", imei: "36942864", memoria: 56);
Console.WriteLine($"O numero do celular Iphone é {iphone.Numero}");
iphone.Ligar();
Console.WriteLine("O número se encontra ocupado!");
iphone.InstalarAplicativo("Instagram");
//