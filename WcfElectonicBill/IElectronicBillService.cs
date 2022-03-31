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
    [ServiceContract]
    public interface IElectronicBillService
    {

        [OperationContract]
        WSResponse AddElectronicBills(List<ElectronicBillModel> electronicBillList);

        [OperationContract]
        WSResponse ValidateElectronicBill(ElectronicBillModel electronicBill);

        [OperationContract]
        WSResponse CalculateIVA(ElectronicBillModel electronicBill);

    }


}
