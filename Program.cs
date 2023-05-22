
internal class Program
{
    private static void Main(string[] args)
    {
        Lunes lunes = new Lunes("lunes", "sistemas a", "sitemas b ", 2, 4);
        lunes.Imprimir();

        Martes martes = new Martes("Martes", "sitemas c", "sistemas d", 2,4);
        martes.Imprimir();

        Miercoles miercoles = new Miercoles("Miercoles", "sistemas e", "sitemas f ", 2, 4);
        miercoles.Imprimir();

        Jueves jueves = new Jueves("Jueves", "sistemas a", "sitemas b ", 2, 4);
        jueves.Imprimir();

        Viernes viernes  = new Viernes ("Jueves", "sistemas a", "sitemas b ", 2, 4);
        viernes .Imprimir();
    }
}
