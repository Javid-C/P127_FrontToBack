using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P127_SendDatas.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string Ram { get; set; }
        public int Count { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
