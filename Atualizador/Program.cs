using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atualizador
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    foreach (Process proc in Process.GetProcessesByName("GDados"))
                    {
                        proc.Kill();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Aplicativo não fechado: " + ex);
                }
                Thread.Sleep(1000);
                File.Delete(Environment.CurrentDirectory + @"\GDados.exe");
                File.Move(Environment.CurrentDirectory + @"\GDadosTemp.exe", Environment.CurrentDirectory + @"\GDados.exe");
                Console.WriteLine("Atualizado com sucesso!");
            }
            catch (Exception) { Console.WriteLine("Update não concluido!"); }
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\GDados.exe");
        }
    }
}
