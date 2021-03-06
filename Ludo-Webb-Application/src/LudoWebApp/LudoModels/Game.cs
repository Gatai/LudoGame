﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LudoWebApp.LudoModels
{
    public class Game
    {
        
        public int GameId { get; set; }
        public GameState GameState { get; set; }
        public Player CurrentPlayer { get; set; }
        public List<Player> Players { get; set; }
        public List<Piece> Pieces { get; set; }
    }
}
