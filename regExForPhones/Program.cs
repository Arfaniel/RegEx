using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace regExForPhones
{
    class Program
    {
        
        static void Main(string[] args)
        {
            WebClient wb = new WebClient();
            string allsite = wb.DownloadString(@"http://www.056.ua/spravka");

            //Console.WriteLine(allsite);

            string pattern = @"\+380\s?\([0-9 -]{1,3}\)\s?[0-9 -]+|[0-9]{2,3}\s?\-[0-9]{2,3}\s?\-[0-9]+|[0-9]{2,3}\s[0-9]{2,3}\s[0-9]+";
            Regex allPhones = new Regex(pattern);
            var phones = allPhones.Matches(allsite);
            foreach (var item in phones)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(phones.Count);

            string KSpattern = @"\+380\s?\((67){1,2}\)\s?[0-9 -]+|\+380\s?\((96){1,2}\)\s?[0-9 -]+|\+380\s?\((68){1,2}\)\s?[0-9 -]+|\+380\s?\((97){1,2}\)\s?[0-9 -]+";
            Regex kyivstar = new Regex(KSpattern);
            var ksArr = kyivstar.Matches(allsite);
            foreach (var item in ksArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ksArr.Count);

            string Vodapattern = @"\+380\s?\((66){1,2}\)\s?[0-9 -]+|\+380\s?\((99){1,2}\)\s?[0-9 -]+|\+380\s?\((95){1,2}\)\s?[0-9 -]+|\+380\s?\((50){1,2}\)\s?[0-9 -]+";
            Regex vodafone = new Regex(Vodapattern);
            var vodaArr = vodafone.Matches(allsite);
            foreach (var item in vodaArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(vodaArr.Count);

            string lifepattern = @"\+380\s?\((63){1,2}\)\s?[0-9 -]+|\+380\s?\((93){1,2}\)\s?[0-9 -]+";
            Regex life = new Regex(lifepattern);
            var lifeArr = life.Matches(allsite);
            foreach (var item in lifeArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(lifeArr.Count);

            

            string regpattern = @"\+380\s?\((562){1,3}\)\s?[0-9 -]+|[(37)]{3}\-[0-9]{2}\-[0-9]+|[(74)]{3}\-[0-9]{2}\-[0-9]+|[(79)]{3}\-[0-9]{2}\-[0-9]+";
            Regex reg = new Regex(regpattern);
            var regArr = reg.Matches(allsite);
            foreach (var item in regArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(regArr.Count);
        }
    }
}
