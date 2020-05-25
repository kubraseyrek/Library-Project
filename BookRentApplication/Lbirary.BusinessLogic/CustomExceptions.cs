using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbirary.BusinessLogic
{
    class RequiredException : Exception
    {
        string _fieldName;

        public RequiredException(string fieldName)
        {
            _fieldName = fieldName;
        }

        public override string Message
        {
            get
            {
                return $"{_fieldName} alanı boş geçilemez";
            }
        }
    }


}
