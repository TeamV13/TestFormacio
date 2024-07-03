using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestFormacio
{
    public class Utils
    {
        public void CalcularDtoComp(decimal Precio, decimal dto1, decimal dto2, decimal dto3)
        {
            Console.WriteLine("{0} | {1} | {2}", dto1, dto2, dto3);

            decimal PrecioNeto = ((Precio * (1 - dto1 / 100)) * (1 - dto2 / 100)) * (1 - dto3 / 100);
            decimal PtgeDtoCom = (Precio - PrecioNeto) / Precio * 100;

            Console.WriteLine("{0} es {1}% ", PrecioNeto.ToString("F2"), PtgeDtoCom.ToString("F2"));

            bool alMenosDosNoSonCero = (dto1 != 0 ? 1 : 0) + (dto2 != 0 ? 1 : 0) + (dto3 != 0 ? 1 : 0) >= 2;

            if (alMenosDosNoSonCero)
            {
                Console.WriteLine("Al menos dos de las variables son distintas de cero.\n");
            }
            else
            {
                Console.WriteLine("No hay al menos dos variables distintas de cero.\n");
            }

        }

        public string CalcularDtoComp(decimal Precio, char sgn, string etiqueta)
        {
            return string.Format("{0} vale {1}"+(Precio*(sgn=='-'?-1:1) > 0 ? "+":"-"),etiqueta, Precio * (sgn == '-' ? -1 : 1));
        }

        public void matCalcularDtoComp(decimal[] dtos, decimal Precio = 100.99m)
        {
            int value = 0;
            decimal PrecioNeto = Precio;
            decimal PtgeDtoCom = 0;

            foreach (var dto in dtos)
            {
                Console.WriteLine("{0}%", dto);
                PrecioNeto = (PrecioNeto * (1 - dto / 100));
            }

            try
            {
                PtgeDtoCom = (Precio - PrecioNeto) / Precio * 100;
                int a = 10 / value;
            }
            catch (Exception ex) {  }
            finally
            {
                Console.WriteLine("{0} es {1}% ", PrecioNeto.ToString("F2"), PtgeDtoCom.ToString("F2"));
            }

        }

        public string Conversion2PTL(string prmCodAlb = "")
        {
            string codalb = prmCodAlb;

            codalb = codalb.Replace(" ", "");

            char[] charArray = new char[] { '/', '-' };
            foreach (char c in charArray)
            {
                if (codalb.Split(charArray).Count() > 0)
                {
                    codalb = codalb.Split(charArray)[codalb.Split(charArray).Count() - 1];
                    break;
                }
            }

            // Dejamos sólo digitos ([0-9], recortamos a 8 carácteres (máx de bproalb.codalb en SS) y eliminamos 0's de la izquierda y compactamos 
            codalb = ClearNumber(codalb);
            codalb = (codalb.Length > 8 ? codalb.Substring(codalb.Length - 8) : codalb).Trim().ToUpper().TrimStart('0').Trim();

            return codalb;
        }

        public static string ClearNumber(string stringToClear)
        {
            string strResult = string.Empty;
            strResult = (string.IsNullOrWhiteSpace(stringToClear) ? string.Empty : Regex.Replace(stringToClear, @"[^0-9]", "").Trim());
            return strResult;
        }


    }
}
