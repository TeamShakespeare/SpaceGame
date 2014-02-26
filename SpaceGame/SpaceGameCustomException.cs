using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public class SpaceGameCustomException : ApplicationException
    {
        private int line; 

        public SpaceGameCustomException(string msg, int line)
            : base(msg)
        {
            this.line = line;
        }

        public SpaceGameCustomException(string msg, Exception innerEx, int line)
            : base(msg, innerEx)
        {
            this.line = line;
        }

        //Methods
        public override string Message
        {
            get
            {
               return base.Message + string.Format("at LINE {0}",this.line);
            }
        }
    }
}
