using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        double DolulukOrani { get; }


    }
}
