namespace ProyectoEvaluacionFJPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Estudiante! Por favor Ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu calificacion: ");
            decimal calificacion = decimal.Parse(Console.ReadLine());

            if (calificacion <= 50)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Estudiante {nombre}, calificacion {calificacion}. Reprobado.");
            }
            else if (calificacion >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Estudiante {nombre}, calificacion {calificacion}. Aprobado.");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.WriteLine($"Estudiante {nombre}, calificacion {calificacion}. Reprobado con derecho a recursar.");

            }
        }
    }
}
