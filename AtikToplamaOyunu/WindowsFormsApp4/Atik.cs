using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection.Emit;

namespace WindowsFormsApp4
{
    public class Atik : IAtik
    {
        public int AtikNo;

        public int atikNo
        {
            get
            {
                return AtikNo;
            }
            set
            {
                atikNo=value;
            }
        }

        public string Ad;

        public string ad
        {
            get
            {
                return Ad;
            }
            set
            {
                ad = value;
            }
        }
        


        public int Hacim;
        public int hacim
        {
            get
            {
                return Hacim;
            }
            set
            {
                hacim = value;
            }
        }

        public Image Image ;
        public Image image
        {
            get { return Image; }
            set { image = value; }
        }

        int IAtik.Hacim => throw new NotImplementedException();

        Image IAtik.Image => throw new NotImplementedException();

        string IAtik.Ad => throw new NotImplementedException();

        int IAtik.AtikNo => throw new NotImplementedException();
    }
}
