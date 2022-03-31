using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfElectonicBill.Model;

namespace WcfElectonicBill
{
    public class ValidatorService
    {
        public static List<string> GetErrors(ElectronicBillModel entity)
        {

            List<string> errors = new List<string>();
            if (!isValidNit(entity.Nit)) errors.Add($"El NIT {entity.Nit},debe contener sólo valores numéricos");
            if (!isValidId(entity.Id)) errors.Add($"El Id {entity.Id},debe ser un valor entero positivo");
            if (!isValidValorTotal(entity.ValorTotal)) errors.Add($"El valor total {entity.ValorTotal}, debe ser positivo");
            if (!isValidIva(entity.Iva)) errors.Add($"El valor del Iva {entity.Iva},debe ser un valor entre 0(%) y 100(%)");
            return errors;

        }

        private static Boolean isValidNit(string nit)
        {
            return nit.All(char.IsDigit);
        }
        private static Boolean isValidId(Int32 id)
        {
            return id >= 0;
        }
        private static Boolean isValidValorTotal(Decimal value)
        {
            return value >= 0;
        }

        private static Boolean isValidIva(Decimal iva)
        {
            return iva >= 0 && iva <= 100;
        }
    }
}