using pdc_api.Model;
using pdc_api.Util;
using System;
using System.Collections.Concurrent;

namespace pdc_api.Services
{
    public static class HoroscopoService
    {
        public static List<string> Sortes { get; set; } = FileUtil.ReadLines("sorte-do-dia.txt");
        public static ConcurrentDictionary<int, string> SortesDoDia { get; set; } = new ConcurrentDictionary<int, string>();  

        public static string SorteDoDia(Usuario usuario)
        {
            var signo = (int)usuario.Signo;
            var sorte = "";

            if (SortesDoDia.TryGetValue(signo, out sorte))
            {
                return sorte;
            }

            var random = new Random();
            sorte = Sortes.ElementAt(random.Next(Sortes.Count));
            SortesDoDia.TryAdd(signo, sorte);
            return sorte;
        }
    }
}
