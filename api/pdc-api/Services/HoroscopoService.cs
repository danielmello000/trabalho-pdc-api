using pdc_api.Model;
using pdc_api.Util;
using System;

namespace pdc_api.Services
{
    public static class HoroscopoService
    {
        public static List<string> Sortes { get; set; } = FileUtil.ReadLines("sorte-do-dia.txt");

        public static string SorteDoDia(string username)
        {
            var random = new Random();
            return Sortes.ElementAt(random.Next(Sortes.Count));
        }
    }
}
