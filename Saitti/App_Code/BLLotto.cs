using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



/// <summary>
/// Summary description for BLLotto
/// </summary>
namespace JAMK.ICT.BL
{
    public class LottoKone
    
    {
        private int NumeroidenLukumaara;
        private int MaxNumero;
        private List<LottoRivi> lottorivit;

        public LottoKone(int lukumaara, int maksimi)
        {
            this.NumeroidenLukumaara = lukumaara;
            this.MaxNumero = maksimi;
        }
        public List<LottoRivi>SuoritaArvonta(int ArvoRiveja)
        {
            for 
        }
    }

    public class LottoRivi
    {
        public LottoRivi(int lukumaara, int maksimi)
        {
            
        }
        public override string ToString()
        {

            
        }
    }
    public class LottoRivit
    {
        List<LottoRivi> lottoRivit;
        public LottoRivit()
        {

            lottoRivit.Add(new LottoRivi());

        }
    }

}