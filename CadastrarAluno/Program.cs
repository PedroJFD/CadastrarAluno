using System;

public class Programa
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Digite a matricula do aluno: ");
            string matricula = Console.ReadLine();

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o CPF do aluno: ");
            string cpf = Console.ReadLine();

            Console.Write("Digite a data de nascimento do aluno: ");
            DateTime datanasci = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Deseja continuar cadastrando?\n0 - Não\n1 - Sim\n");
            Console.Write("Resposta: ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            Aluno pedro = new Aluno(matricula, nome, cpf, datanasci);

            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(pedro);

            if(escolha == 0)
            {
                //alunos devem aparecer aqui, por q fora nao funciona o list
                //descobrir como declarar alunos objeto
                break;
            }

        }
    }
}