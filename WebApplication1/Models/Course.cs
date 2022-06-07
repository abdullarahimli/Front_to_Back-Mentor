using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserIcon { get; set; }
        public string UserCount { get; set; }
        public string LikeIcon { get; set; }
        public string LikeCount { get; set; }
        public Category Categories { get; set; }
        public int CategoriesId { get; set; }
        public Trainer Trainers { get; set; }
        public int TrainersId { get; set; }

    }
}
