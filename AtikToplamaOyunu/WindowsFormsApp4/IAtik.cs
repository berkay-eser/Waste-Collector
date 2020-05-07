using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp4
{
    public interface IAtik
    {
        string Ad { get; }
        int AtikNo { get; }
        int Hacim { get; }
        Image Image { get; }
    }
}
