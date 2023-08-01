public class Aluno
{
    public string matricula;
    public string nome;
    public string cpf;
    public DateTime datanasci;

    public Aluno(string matricula, string nome, string cpf, DateTime datanasci)
    {
        this.matricula = matricula;
        this.nome = nome;
        this.cpf = cpf;
        this.datanasci = datanasci;
    }
}