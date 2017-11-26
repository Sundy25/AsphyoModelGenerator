using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEUAsphyo;
using Microsoft.SqlServer.Management.SqlParser.Parser;
using BEUAsphyo.Exception;

namespace BLAsphyo {

    public class BLSqlParser {

        public static bool Validate(string query) {
            var result = Parser.Parse(query, new ParseOptions("GO", true, Microsoft.SqlServer.Management.SqlParser.Common.DatabaseCompatibilityLevel.Version140, Microsoft.SqlServer.Management.SqlParser.Common.TransactSqlVersion.Version140));
            if( result.Errors.Any() ) {
                throw new BEUParseException(result.Errors.Select(e => e.Message).ToList()[0]);
            }
            return true;
        }
    }
}
