using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Game
    {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private Board boardGame;
        private bool endGame;

        //Constructor
        public Game()
        {
            Random random = new Random();
            players = new Player[2] { new Player(), new Player() };
            ActivePlayer = players[random.Next(0, 2)];
            boardGame = new Board();
            EndGame = false;

        }
        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
        }
        public bool EndGame
        {
            get
            {
                return this.endGame;
            }
            set
            {
                endGame = value;
            }
        }

        //Metodos
        public bool CheckIfEndGame()
        {
            var i = 0;

            while (i < players.Length) {
                if (players[i].LifePoints == 0) {
    
                    return true;
                    
                }
                i += 1;

            }

            return false;
        }
        public int GetWinner()
        {

            var i = 0;

            var idganador  = 0;

            while (i < players.Length)
            {
                if (players[i].LifePoints == 0)
                {

                    Console.WriteLine("Perdedor = " + players[i].Id);

                } else {
                    idganador = players[i].Id;
                }
                i += 1;

            }


            return idganador;




        }
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
