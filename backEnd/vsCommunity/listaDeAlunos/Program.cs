using System;
using System.Collections.Generic;

namespace listaAlunosAndre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ⚔️ MISSÃO DE EXPEDIÇÃO: LISTA DE ALUNOS ⚔️ ===\n");

            List<string> alunos = new List<string>();

            alunos.Add("Maria");
            alunos.Add("João");
            alunos.Add("Ana");

            Console.WriteLine($"Aluno na posição 0: {alunos[0]}");

            Console.WriteLine($"Quantidade inicial de alunos (Count): {alunos.Count}\n");

            bool temAna = alunos.Contains("Ana");
            Console.WriteLine($"A lista contém 'Ana'? {temAna}");

            int indiceAna = alunos.IndexOf("Ana");
            Console.WriteLine($"Índice da 'Ana': {indiceAna}\n");

            alunos.Sort();
            Console.WriteLine("Lista após o Sort() (Ordem Alfabética):");
            ExibirAlunosIEnumerable(alunos);

            alunos.Reverse();
            Console.WriteLine("\nLista após o Reverse() (Invertida):");
            ExibirAlunosIEnumerable(alunos);

            alunos.Remove("João");
            Console.WriteLine("\n'João' foi removido com Remove().");

            alunos.Insert(1, "Carlos");
            Console.WriteLine("'Carlos' foi inserido no índice 1 com Insert().");

            alunos.RemoveAt(0);
            Console.WriteLine("Item do índice 0 foi removido com RemoveAt().\n");

            Console.WriteLine("Estado atual da lista antes da funcionalidade autoral:");
            ExibirAlunosIEnumerable(alunos);

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("--- DEMONSTRAÇÃO DO IENUMERABLE (+2 XP) ---");
            Console.WriteLine("--------------------------------------------------");

            alunos.Add("André");
            alunos.Add("Bia");
            alunos.Add("Alexandre");
            alunos.Add("Cauã");
            alunos.Add("Luiz Miguel");

            Console.WriteLine("Exibindo lista inteira usando o contrato IEnumerable<T>:");
            ExibirAlunosIEnumerable(alunos);

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("--- SISTEMA DE PRESENÇA E DEVER DE CASA (+2 XP) ---");
            Console.WriteLine("--------------------------------------------------");

            GerenciarPresencaEDever(alunos);

            Console.WriteLine("\nFinalizando a expedição e limpando a lista com Clear()...");
            alunos.Clear();
            Console.WriteLine($"Quantidade final de alunos após Clear(): {alunos.Count}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        public static void ExibirAlunosIEnumerable(IEnumerable<string> colecaoAlunos)
        {
            foreach (string aluno in colecaoAlunos)
            {
                Console.WriteLine($" - Aluno: {aluno}");
            }
        }

        public static void GerenciarPresencaEDever(List<string> listaAlunos)
        {
            Console.WriteLine("\n[ Painel do Professor: Registro de Presença e Dever de Casa ]");

            foreach (string aluno in listaAlunos)
            {
                int xpGanho = 0;

                Console.WriteLine($"\n📌 Avaliando o aluno(a): {aluno}");

                Console.Write($" O aluno '{aluno}' está presente? (S/N): ");
                string respPresenca = Console.ReadLine()?.Trim().ToUpper();

                if (respPresenca == "S")
                {
                    xpGanho += 1;
                    Console.WriteLine($"   ✔️ Presença confirmada! (+1 XP)");

                    Console.Write($" O aluno '{aluno}' fez o dever de casa/caderno? (S/N): ");
                    string respDever = Console.ReadLine()?.Trim().ToUpper();

                    if (respDever == "S")
                    {
                        xpGanho += 1;
                        Console.WriteLine($"   📚 Dever de casa verificado! (+1 XP)");
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ Dever de casa não entregue. (+0 XP)");
                    }
                }
                else
                {
                    Console.WriteLine($"   ❌ Aluno ausente na aula. (+0 XP)");
                }

                Console.WriteLine($" ⭐ Total de XP acumulado por {aluno} nesta aula: +{xpGanho} XP");
            }
        }
    }
}