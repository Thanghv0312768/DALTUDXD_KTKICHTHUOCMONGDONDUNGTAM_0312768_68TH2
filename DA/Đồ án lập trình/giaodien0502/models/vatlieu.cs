using ETABSv1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodien0502.models
{
    public class vatlieu
    {
        public string concretegrade {  get; set; } // cấp độ bền bê tông 
        public double Rb { get; set; } // Cường độ chịu nén tính toán (Mpa)
        public double Rbt { get; set; } // cường độ chịu kéo tính toán (MPa)
        public double Rs { get; set; } // Cường độ chịu kéo cốt thép (Mpa)
        public vatlieu ( double rb , double rbt , double rs)
        { Rb = rb; Rbt = rbt; Rs = rs;  }
    }
}
