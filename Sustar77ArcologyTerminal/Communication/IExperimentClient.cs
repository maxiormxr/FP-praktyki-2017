using Sustar77ArcologyTerminal.Model;
using System.Collections.Generic;
using System.Net;

namespace Sustar77ArcologyTerminal.Communication
{
    public interface IExperimentClient
    {
        Result Describe(string login, string token);
        HttpStatusCode Execute(string command);
        HttpStatusCode Execute(string command, string parameter);
        List<string> getActionList();
    }
}