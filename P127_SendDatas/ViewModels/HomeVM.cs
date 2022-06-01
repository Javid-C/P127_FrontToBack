using P127_SendDatas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P127_SendDatas.ViewModels
{
    public class HomeVM
    {
        public List<Computer> Computers { get; set; }
        public List<Card> Cards { get; set; }
    }
}
