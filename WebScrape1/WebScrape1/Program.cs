using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrapySharp;
using HtmlAgilityPack;
using ScrapySharp.Extensions;

namespace WebScrape1
{
    class Program
    {
        static void Main(string[] args)
        {
            var web = new HtmlWeb();
            var page = web.Load("https://www.amazon.com/");

            var items = page.DocumentNode.CssSelect("li.a-carousel-card");

            foreach (var item in items)
            {
                Console.WriteLine(item.InnerText);
            }
        }
    }
}
