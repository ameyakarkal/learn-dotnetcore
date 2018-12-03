using System.Collections.Generic;

namespace Services
{
    public interface IValuesService
    {
        IEnumerable<string> Get();

    }

    public class ValuesService : IValuesService
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "01", "02" };
        }
    }
}