﻿using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var jogo = new JogoFODA( new Jogador2(), new Jogador1("Ronaldo"));
            jogo.IniciarJogo();
        }
    }



}
