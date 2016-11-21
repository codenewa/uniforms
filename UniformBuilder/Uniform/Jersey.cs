using System;
using UniformBuilder.Options;
using UniformBuilder.Style;
using UniformBuilder.Utility;

namespace UniformBuilder.Uniform
{
    public class Jersey: Root
    {
        public Jersey()
        {
            
        }
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Identifier { get; set; }
        public virtual Color BodyColor { get; set; }
        public virtual Color InsertsColor { get; set; }
        public virtual TeamNameSelection TeamName { get; set; }
        public virtual PlayerNameSelection PlayerName { get; set; }
        public virtual PlayerNumberSelection PlayerNumber { get; set; }

        public virtual Jersey Create(string name, string description, string identifier, Color color, Color insertColor, TeamNameSelection teamNameSelection, 
            PlayerNameSelection playerNameSelection, PlayerNumberSelection numberSelection, User user)
        {
            return new Jersey()
            {
                Id = IdGenerator.NewId(),
                BodyColor = color,
                InsertsColor = insertColor,
                TeamName = teamNameSelection,
                PlayerName = playerNameSelection,
                PlayerNumber = numberSelection,
                LastUpdatedBy = user,
                Creator = user,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };
        }  
    }
}
