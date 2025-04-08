using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankProject1.Blocks
{
    public class ComplexBlock : BaseBlock
    {
        private List<BaseBlock> blocks;

        public ComplexBlock()
        {
            blocks = new List<BaseBlock>();
        }

        public void Add(BaseBlock block)
        {
            blocks.Add(block);
        }
        public override double Calc(double x)
        {
            double res = x;
            foreach (var b in blocks)
            {
                res = b.Calc(res);
            }
            return res;
        }
    }
}
