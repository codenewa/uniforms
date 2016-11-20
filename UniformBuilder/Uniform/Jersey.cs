using System;
using UniformBuilder.Options;
using UniformBuilder.Style;
using UniformBuilder.Utility;

namespace UniformBuilder.Uniform
{
    public class Jersey
    {
        public virtual Guid Id { get; set; }
        public virtual Color BodyColor { get; set; }
        public virtual Color InsertsColor { get; set; }
        public virtual TeamNameSelection TeamName { get; set; }
        public virtual PlayerNameSelection PlayerName { get; set; }
        public virtual PlayerNumberSelection PlayerNumber { get; set; }

        public virtual Jersey Create(Color color, Color insertColor, TeamNameSelection teamNameSelection, 
            PlayerNameSelection playerNameSelection, PlayerNumberSelection numberSelection)
        {
            return new Jersey()
            {
                Id = IdGenerator.NewId(),
                BodyColor = color,
                InsertsColor = insertColor,
                TeamName = teamNameSelection,
                PlayerName = playerNameSelection,
                PlayerNumber = numberSelection
            };
        }  
    }
}
