using Planilla;


Empleado emp1 = new EmpleadoSalario("Anibal Lecter", 201, 24_000);

EmpleadoPorHora emp2 = new EmpleadoPorHora("Luis Cordova", 202, 500);
emp2.Horas = 160;

EmpleadoComision emp3 = new EmpleadoComision("Veronica Gomez", 301, 5);
emp3.Ventas = 1_000_000;

Empleado[] planilla = { emp1, emp2, emp3 };

foreach (Empleado emp in planilla)
{
    Console.WriteLine(emp);
}