using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Exception
{
    public class SameBookAlreadyAddedExpection:SystemException
    {
        public SameBookAlreadyAddedExpection(string massage):base(massage)
        {
        }
        public SameBookAlreadyAddedExpection(string message, SameBookAlreadyAddedExpection sameBookalreadyAddedExpection) : base(message, sameBookalreadyAddedExpection)
        {
        }
    }
}
