using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUAsphyo.Exception {
    public class BEUParseException : System.Exception{
        public BEUParseException() { }
        public BEUParseException(String Message) : base(Message) {  }
        public BEUParseException(String Message, System.Exception ex) : base(Message, ex) { }
    }
}
