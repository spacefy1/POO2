using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using WpfApp1.model;

namespace WpfApp1.BD
{
    internal class BD
    {
        public static List<IdeiaInovacao> mybd = new();

        public static void SalvarBD(IdeiaInovacao ideia) => mybd.Add(ideia);

        public static List<IdeiaInovacao> RetornarBD() => mybd;

    }
}
