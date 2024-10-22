using System;
using System.Collections.Generic;

namespace Game.Domain
{
    public class GameTurnEntity
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        
        public int TurnNo { get; set; }
        
        public readonly Dictionary<string, PlayerDecision> PlayerDecisions;
        public Guid WinnerId { get; set; }

        public GameTurnEntity(Guid gameId, Guid winnerId, Dictionary<string, PlayerDecision> playerDecisions, int turnNo)
            : this(new Guid(), gameId, winnerId, playerDecisions, turnNo)
        {

        }
        
        public GameTurnEntity(Guid id, Guid gameId, Guid winnerId, Dictionary<string, PlayerDecision> playerDecisions, int turnNo)
        {
            Id = id;
            GameId = gameId;
            PlayerDecisions = playerDecisions;
            TurnNo = turnNo;
            WinnerId = winnerId;
        }
    }
}