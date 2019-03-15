using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNETUdemy.Data.Converter
{
    public interface IParser<Source, Destiny>
    {
        Destiny Parse(Source source);
        List<Destiny> ParseList(List<Source> source);
    }
}
