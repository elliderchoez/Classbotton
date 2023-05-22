class Martes : Horario
{
    private  string materia1;
    private  string materia2;
    private  int hora1;
    private  int hora2;
    private string dia;
   

    public Martes( string dia, string materia1, string materia2, int hora1, int hora2) : base(dia, materia1, materia2, hora1, hora2)
    {
        this.materia1 = materia1;
        this.materia2 = materia2;
        this.hora1 = hora1;
        this.hora2 = hora2;
        this.hora1 = hora2;
        
        this.dia = dia;
    }

    public void Horario()
    {
        dia = "Martes";
        materia1 = "Sitemas c";
        materia2 = "Sitemas d";
        hora1 = 2;
        hora2 = 4;
    }
    
    public  new void Imprimir()
    {
        Console.WriteLine("Las materias del dia {0} son: {1} y {2}, la hora de inicio de la {1} es de {3} y de la materia {2} es de {4}",dia,materia1,materia2,hora1,hora2 );
    }
}