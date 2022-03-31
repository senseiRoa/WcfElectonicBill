using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfElectonicBill.Model;

namespace WcfElectonicBill
{
    public class ElectronicBillService : IElectronicBillService
    {


        public WSResponse AddElectronicBills(List<ElectronicBillModel> electronicBillList)
        {
            WSResponse response = new WSResponse();
            try
            {
                var errorRepeatedId = electronicBillList
                          .GroupBy(x => x.Id)
                          .Where(g => g.Count() > 1)
                          .Select(y => y.Key)
                          .ToList();

                if (errorRepeatedId.Count > 0) throw new Exception("No pueden existir 2 facturas con el mismo Id");

                foreach (var item in electronicBillList)
                {

                    var errors = ValidatorService.GetErrors(item);
                    if (errors.Count > 0)
                    {
                        response.Messages.AddRange(errors);
                    }

                }
                if (response.Messages.Count == 0)
                {
                    var sum = electronicBillList.Sum(i => i.ValorTotal);
                    response.ResultData = sum;
                    response.State = StateResponse.Success;
                    response.Messages.Add("Se ha calculado la suma de todos los Valores totales satisfactoreamente");
                }


            }
            catch (Exception ex)
            {

                response.Messages.Add(ex.Message);
            }

            return response;
        }


        public WSResponse ValidateElectronicBill(ElectronicBillModel electronicBill)
        {
            WSResponse response = new WSResponse();
            try
            {
                var errors = ValidatorService.GetErrors(electronicBill);
                if (errors.Count > 0)
                {
                    response.Messages.AddRange(errors);
                }
                else
                {
                    response.State = StateResponse.Success;
                    response.Messages.Add("La Factura Electronica es correcta");
                    response.ResultData = true;
                }

            }
            catch (Exception ex)
            {

                response.Messages.Add(ex.Message);
            }

            return response;
        }

        public WSResponse CalculateIVA(ElectronicBillModel electronicBill)
        {

            WSResponse response = new WSResponse();
            try
            {
                var errors = ValidatorService.GetErrors(electronicBill);
                if (errors.Count > 0)
                {
                    response.Messages.AddRange(errors);
                }
                else
                {
                    response.ResultData = (Decimal)(electronicBill.Iva * electronicBill.ValorTotal) / (Decimal)100;
                    response.State = StateResponse.Success;
                    response.Messages.Add("Se ha calculado el valor del IVA correctamente");
                }

            }
            catch (Exception ex)
            {

                response.Messages.Add(ex.Message);
            }

            return response;
        }


    }
}
