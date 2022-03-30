using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class Orderlier
    {

        public static string Sorttxt(string caminho)
        {

            string txt = System.IO.File.ReadAllText(caminho);
            string[] arraytxt = txt.Split(',');
            double[] arraytxtdouble = new double[arraytxt.Length];
            string arrayordered = "";
            string nomearquivo = Path.GetFileName(caminho);

            for (int i = 0; i < arraytxt.Length; i++)
            {
                arraytxtdouble[i] = double.Parse(arraytxt[i]);
            }

            Array.Sort(arraytxtdouble);

            for (int i = 0; i < arraytxt.Length; i++)
            {
                arrayordered += arraytxtdouble[i] + ",";
            }



            File.WriteAllText("../../../ArquivosOrdenados/"+nomearquivo.Replace(".txt", "Ordenado.txt"), arrayordered);

            return arrayordered;

        }

    }
}
