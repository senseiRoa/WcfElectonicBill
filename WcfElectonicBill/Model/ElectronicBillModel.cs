using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfElectonicBill.Model
{
    [DataContract]
    public class ElectronicBillModel
    {

        [DataMember]
        public Int32 Id { get; set; }

        [DataMember]
        public string Nit { get; set; }


        [DataMember]
        public Decimal ValorTotal { get; set; }


        [DataMember]
        public Decimal Iva { get; set; }
    }

}