class Program
{
    static void Main(string[] args)
    {
        string ruta = @"temp\prueba.txt";
        //File.Create(ruta);
        File.WriteAllText(ruta, "Hola mundo\nHoy es jueves");
        File.AppendAllText(ruta, "Mañana es viernes");
        File.AppendAllLines(ruta, new string[] { "1", "2", "3" });
        File.AppendAllLines(ruta, new List<string>  { "1", "2", "3" });
        File.rea
    }
}