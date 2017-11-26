using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUAsphyo.Exception {
    public class BEUExceptionBL : System.Exception{
        public BEUExceptionBL() { }
        public BEUExceptionBL(string message) : base(message){ }
        public BEUExceptionBL(string message, System.Exception inner) : base(message, inner){ }
    }
}
