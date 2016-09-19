using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLotto
/// </summary>
namespace JAMK.ICT.BL
{
    public static class LottoArvonta
    {

        public static DataTable dtArvoLottoNumerot(string strArvonta, int intLukumaaraArvottavia, int intRuudukonMaksimi, int intRivienLukumaara)
        {
            DataTable dt = new DataTable();
            LottoKone lottoa = new LottoKone(strArvonta, intLukumaaraArvottavia, intRuudukonMaksimi, intRivienLukumaara);
            List<LottoRivi> lottorivit = lottoa.getRivit();
            LottoRivi lottorivi = null;

            dt.Columns.Add("#");
            dt.Columns.Add(strArvonta);

            for (int f = 0; f < lottorivit.Count; f++)
            {
                lottorivi = lottorivit[f];
                dt.Rows.Add(f, lottorivi.ToString());
            }
            return dt;
        }

        public class LottoKone
        {
            //Random numeroidenArpoja = new Random();
            Random rnd = new Random((int)DateTime.Now.Ticks);
            string strKoneenNimi;
            int intLukumaaraArvottavia;
            int intRuudukonMaksimi;
            int intRivienLukumaara;
            

            //private LottoRivit lottorivit = null;
            private List<LottoRivi> lottorivit = new List<LottoRivi>();

            public LottoKone(string strKoneenNimi, int intLukumaaraArvottavia, int intRuudukonMaksimi, int intRivienLukumaara)
            {
                this.strKoneenNimi = strKoneenNimi;
                this.intLukumaaraArvottavia = intLukumaaraArvottavia;
                this.intRuudukonMaksimi = intRuudukonMaksimi;
                this.intRivienLukumaara = intRivienLukumaara;
                arvoRivit(intRivienLukumaara);
            }

            public void arvoRivit(int intRivienLukumaara)
            {
                LottoRivi arvottuRivi = null;
                for (int i = 1; i <= intRivienLukumaara; i++)
                {
                    arvottuRivi = new LottoRivi(rnd, this.intLukumaaraArvottavia , this.intRuudukonMaksimi);
                    lottorivit.Add(arvottuRivi);
                }
            }

            public List<LottoRivi> getRivit()
            {
                return (lottorivit);
            }

            
        }
    }
    public class LottoRivi
    {
        List<int> arvotutNumerot = null;

        public LottoRivi(Random rnd, int lukumaara, int maksimi)
        {
            int arvottuNumero = 0;
            arvotutNumerot = new List<int>();
            while (true)
            {
                //arvotaan numero
                arvottuNumero = rnd.Next(1, maksimi + 1);
               if (!arvotutNumerot.Contains(arvottuNumero))
                {
                    arvotutNumerot.Add(arvottuNumero);
                }
                if (arvotutNumerot.Count >= lukumaara)
                {
                    break;
                }
            }
            arvotutNumerot.Sort();
        }
        public override string ToString()
        {
            return String.Join(", ", arvotutNumerot);
        }
    }
}