double area, raio;
double n = 3.14159;

Console.WriteLine("Informe o valor de raio para o programa calcular a área de seu respectivo círculo:\n");   

Console.Write("Raio do círculo: ");
raio = Convert.ToDouble(Console.ReadLine());
        
area = n*Math.Pow(raio, 2);
        
Console.WriteLine($"Área do círculo: {area}");