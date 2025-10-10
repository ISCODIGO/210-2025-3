// Dias de la semana Domingo (0) -> Sabado (6)
//int.TryParse(Console.ReadLine(), out int opcion);

//switch (opcion)
//{
//    case 0:
//        Console.WriteLine("Domingo");
//        break;
//    case 1:
//        Console.WriteLine("Lunes");
//        break;
//    case 2:
//        Console.WriteLine("Martes");
//        break;
//    case 3:
//        Console.WriteLine("Miercoles");
//        break;
//    case 4:
//        Console.WriteLine("Jueves");
//        break;
//    case 5:
//        Console.WriteLine("Viernes");
//        break;
//    case 6:
//        Console.WriteLine("Sabado");
//        break;
//    default:
//        Console.WriteLine("** Valor invalido **");
//        break;

//}

//string dia = opcion switch
//{
//    0 => "Domingo",
//    1 => "Lunes",
//    2 => "Martes",
//    3 => "Miercoles",
//    4 => "Jueves",
//    5 => "Viernes",
//    6 => "Sabado",
//    _ => "** Invalido **"
//};
//Console.WriteLine(dia);

// Programa que emita NSP: 0, ABD: 1-30, RPB: 31-64, APR: 65-90, EXC: 91-100
Console.Write("Escriba la nota: ");
int.TryParse(Console.ReadLine(), out int nota);

string mensaje = nota switch
{
    < 0 or > 100 => "** Invalido **",
    0 => "NSP",
    <= 30 => "ABD",
    <= 64 => "RPB",
    <= 90 => "APR",
    <= 100 => "EXC"
};
Console.WriteLine(mensaje);