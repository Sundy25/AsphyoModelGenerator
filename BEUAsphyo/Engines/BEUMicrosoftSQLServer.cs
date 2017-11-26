using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUAsphyo.Engines {
    public class BEUMicrosoftSQLServer {

        public BEUMicrosoftSQLServer() {
            this.DataSource = "";
            this.Username = "";
            this.Password = "";
        }
        public String DataSource { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public bool IntegratedSecurity { get; set; }
    }
}
