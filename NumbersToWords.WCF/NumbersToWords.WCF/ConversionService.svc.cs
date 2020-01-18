using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NumbersToWords.WCF
{
   
    public class ConversionService : IConversionService
    {

        public string Convert(float value)
        {
            
            return "ok";
        }

    }

}
