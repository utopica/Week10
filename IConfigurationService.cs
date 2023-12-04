using System;

namespace Week10
{
    public interface IConfigurationService
    {
        IConfigurationService GetInstance();

        string GetValue(string key);
    }
}
