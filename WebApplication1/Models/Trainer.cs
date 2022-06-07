using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Description { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }

        public Nullable<int> TrainerPositionId { get; set; }
        public TrainerPosition TrainerPosition { get; set; }
        public Course Course { get; set; }
        
    }
}
