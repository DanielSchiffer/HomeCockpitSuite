using System;
using System.Collections.Generic;
using System.Text;

namespace DanielSchiffer.HCS.Contracts.CockpitContract
{
    public interface IFlightSimInterface
    {
        event EventHandler<String> LogEntryReceived;
        event EventHandler VariableListChanged;
        event EventHandler ValuesChanged;

        bool Start();
    }
}
