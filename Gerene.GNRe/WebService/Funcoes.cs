using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Gerene.GNRe.WebService
{
    public static class Funcoes
    {
        public static bool IsValidXml(this string xmlstring)
        {
            try
            {
                var xDocument = XDocument.Parse(xmlstring);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
