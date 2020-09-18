using AutofacUse.contract;

namespace AutofacUse.Service
{
    public class DataProvider : IDataProvider
    {
        public string Get()
        {
            return "Test data";
        }

    }
}