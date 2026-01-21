using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversionPrinciple
{
    /// <summary>
    /// This interface represents an abstraction for message services.
    /// High-level modules should depend on this abstraction rather than concrete implementations.
    /// </summary>
    public interface IMessageService
    {
         void SendMessage(string message);
    }
}