using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class AtikKutusu : IAtikKutusu
    {
        public int BosaltmaPuani;
        public int bosaltmaPuani
        {
            get
            {
                return BosaltmaPuani;
            }
            set
            {
                bosaltmaPuani = value;
            }
        }


        public int Kapasite;
        public int kapasite
        {
            get
            {
                return Kapasite;
            }
            set 
            {
                kapasite = value;
            }
        }

        public int DoluHacim;
        public int doluHacim
        {
            get
            {
                return DoluHacim;
            }
            set
            {
                doluHacim = value;
            }
        }

        public double DolulukOrani;
        public double dolulukOrani
        {
            get
            {
                return DolulukOrani;
            }
            set
            {
                dolulukOrani = value;
            }
        }

        

        int IAtikKutusu.BosaltmaPuani => throw new NotImplementedException();

        

        int IDolabilen.Kapasite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        int IDolabilen.DoluHacim => throw new NotImplementedException();

        double IDolabilen.DolulukOrani => throw new NotImplementedException();

        public bool Bosalt()
        {

            if (DolulukOrani >= 0.75)
            {
                DoluHacim = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Ekle(string atik)
        {
            if(( DoluHacim) <= Kapasite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

    }
}
