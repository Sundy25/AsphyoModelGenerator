using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUAsphyo.Exception {
    public class BEUExceptionDAO : System.Exception {

        public BEUExceptionDAO() { }
        public BEUExceptionDAO(string message) : base(message){ }
        public BEUExceptionDAO(string message, System.Exception inner) : base(message, inner){ }
    }
}
