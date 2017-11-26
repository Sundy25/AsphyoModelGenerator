using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUAsphyo.Templates {
    public class BEUTemplates {

        public String getBEUWithAsphyoReferences() {
            return new UTF8Encoding(false).GetString(global::Model.Properties.Resources.BEUTemplateAsphyo).Trim();
        }

        public String getDAOWithAsphyoReferences() {
            return new UTF8Encoding(false).GetString(global::Model.Properties.Resources.DAOTemplateAsphyo).Trim();
        }

        public String getBEUNormal() {
            return new UTF8Encoding(false).GetString(global::Model.Properties.Resources.BEUTemplateNormal).Trim();
        }

        public String getDAONormal() {
            return new UTF8Encoding(false).GetString(global::Model.Properties.Resources.DAOTemplateNormal).Trim();
        }

        public String getConnectionFile() {
            return new UTF8Encoding(false).GetString(global::Model.Properties.Resources.MySQL).Trim();
        }
    }
}
