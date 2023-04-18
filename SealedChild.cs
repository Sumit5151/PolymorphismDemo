using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class SealedChild
    {
        public void Display()
        {
            SealedParnet sealedParnet = new SealedParnet();
            sealedParnet.Show();
        }
    }
}
