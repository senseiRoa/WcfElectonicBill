using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfElectonicBill.Model
{
    public class WSResponse
    {
        public WSResponse()
        {
            this.State = StateResponse.Error;
            this.Messages = new List<string>();
            this.ResultData = false;

        }
        public string State { get; set; }
        public dynamic ResultData { get; set; }
        public List<string> Messages { get; set; }
    }

    public class StateResponse
    {
        public const string Error = "Error";
        public const string Success = "Exito";
    }
}