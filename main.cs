using System;
using System.IO;


class MainClass {
  public static void Main (string[] args) {
    

    Cliente novoCliente = new Cliente ("Valério", 21);
    novoCliente.VerCliente (novoCliente.Nome, novoCliente.Idade);
    StreamReader sr = null;
    
        
        try {
                
                using (sr = File.OpenText ("Informação.txt")) {
                        while (!sr.EndOfStream){
                                string line = sr.ReadLine();
                                Console.WriteLine (line);                     
                        }               
                } 
                            
        }
        catch (IOException e) {
                Console.WriteLine ("Ocorreu um erro !");
                Console.WriteLine (e.Message);
        }    

  }
}