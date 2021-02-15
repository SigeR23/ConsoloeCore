using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
         public readonly string _nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _nome = nome;
        }

        public string Chuta()
        {
            return $"{_nome} está chutando.";
        }

        public string Corre()
        {
             return $"{_nome} está correndo.";
        }

        public string Passa()
        {
            return $"{_nome} está passando.";
        }
    }
}