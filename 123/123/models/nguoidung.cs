using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123.models
{
    internal class nguoidung
    {
        public nguoidung() { }
        public float kichthuoc { get; set; }
        public float phi { get; set; }
        public float gamma { get; set; }
        public float c { get; set; }
        public float IL { get; set; }
        public float E { get; set; }
        public float h { get; set; }
        public float MNN { get; set; }
        public nguoidung (float kichthuoc, float phi, float gamma, float c, float IL, float E, float h, float MNN)
        {
            this.kichthuoc = kichthuoc;
            this.phi = phi;
            this.gamma = gamma;
            this.c = c;
            this.IL = IL;
            this.E = E;
            this.h = h;
            this.MNN = MNN;
        }
    }
}
