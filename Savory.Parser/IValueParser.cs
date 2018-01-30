using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Savory.Parser
{
    public interface IValueParser<T>
    {
        T Parse(string input);

        bool TryParse(string input, out T result);
    }
}
