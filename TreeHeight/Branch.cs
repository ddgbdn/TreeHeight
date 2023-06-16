using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHeight
{
    // I would prefer changing Branch -> Node and branches -> Children
    public class Branch
    {
        public List<Branch> Branches = new List<Branch>();
    }
}
