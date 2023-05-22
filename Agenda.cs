class Agenda
{
    private Lunes lunes;
    private List<Lunes> listamateria = new List<Lunes>();
    private  string materia1;
    private  string materia2;
    private  int hora1;
    private  int hora2;
    private  string dia;


     public void añadirmateria(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            Console.WriteLine("Ingrese la materias" + i );
            Console.WriteLine("Ingrese materia1");
            materia1 = Console.ReadLine();
            Console.WriteLine("Ingrese materia2");
            materia2 = Console.ReadLine();
            Console.WriteLine("Ingrese la hora de la materia1");
            hora1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese  la hora de la materia2");
            hora2 = int.Parse(Console.ReadLine());
            lunes = new Lunes(dia, materia1, materia2, hora1, hora2);
            listamateria.Add(lunes);
        }
    }


}

