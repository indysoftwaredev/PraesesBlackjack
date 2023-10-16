﻿using Blackjack.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.App
{
    public class Game
    {
        private readonly IInteractionService _interactionService;

        public Game(IInteractionService interactionService)
        {
            _interactionService = interactionService;
        }

        public List<Player> Players { get; set; } = new List<Player>();

        public void Setup()
        {
            int numberOfPlayers = _interactionService.GetNumberOfPlayers();

            for(int i = 0; i < numberOfPlayers; i++)
            {
                Players.Add(new Player());
            }
        }
    }
}
