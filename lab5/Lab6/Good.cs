using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Good
    {
        public int Id { get; set; }
        public string nameAndSurname { get; set; }
        public string modelName { get; set; }
        public string date { get; set; }
        public bool result { get; set; }
        public string executionTime { get; set; }
        public Model type { get; set; }
    }
}
