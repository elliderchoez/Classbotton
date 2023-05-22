class Horario
{
    private  string materia1;
    private  string materia2;
    private  int hora1;
    private  int hora2;
    private string dia;


    public Horario(string _materia1, string _materia2, int _hora1, int _hora2, string _dia)
    {
        this.materia1 = _materia1;
        this.materia2 = _materia2;
        this.hora1 = _hora1;
        this.hora2 = _hora2;
        this.hora1 = _hora2;
        this.dia = _dia;
        
    }

    public string _materia1 { get => materia1; set => materia1 = value; }
    public string _materia2 { get => materia2; set => materia2 = value; }
    public int _hora1 { get => hora1; set => hora1 = value; }
    public int _hora2 { get => hora2; set => hora2 = value; }
    
    

    public virtual string Imprimir()
    {
        return  " materia1 "+materia1+ ", materi2 "+materia2+ ", hora1 "+hora1+ ", hora2 "+hora2;
    }






}