int año;
int edad;


try
{
    Console.Write("En que año cumpleaños?");
    año = Convert.ToInt32(Console.ReadLine());

    edad = (2022 - año);
    Console.WriteLine($"Waw no aparentas de {edad} años");
}   catch(Exception ex)
{
    Console.WriteLine("Ups, no me entendiste, es un numero");
    Console.WriteLine("La excepcion es: " + ex.Message);
}
