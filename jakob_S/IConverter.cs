using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jakob_S
{
    internal interface IConverter
    {
        //Konverter en besked
        string ConvertBodyToHTML(string message);
    }
}
