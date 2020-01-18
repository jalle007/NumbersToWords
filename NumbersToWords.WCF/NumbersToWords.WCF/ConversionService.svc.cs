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

     
        public Response Convert(string value)
        {
            var result = Convertor.Convert(value);

            return new Response()
            {
                result = result,
                error = (result == null ? "Wrong input format." :  null)
            };
        }
    }

}
