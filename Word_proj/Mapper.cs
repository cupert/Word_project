using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_proj
{
    public class Mapper : MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            //context.EmitKeyValue(inputLine, 1);
        }

    }
}
