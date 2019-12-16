using System;
using System.IO;

class Cliente {
        public string Nome;
        public int Idade;
        public string reservas = "Reservas";

        public Cliente (string nome, int idade) {
                Nome = nome;
                Idade = idade;
        }

        public void VerCliente (string nome, int idade) {
                StreamWriter escrita;
                escrita = File.AppendText ("Informação.txt");
                escrita.WriteLine (nome);
                escrita.WriteLine (idade);
                escrita.Close();
        }


        if (!Directory.Exists (reservas)) {
                Directory.CreateDirectory ("Reservas");
        }
        

        

        




}