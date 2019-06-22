using System;

namespace Pacco.Services.Vehicles.Core.Exceptions
{
    public abstract class ExceptionBase : Exception
    {
        public abstract string Code { get; }

        protected ExceptionBase(string message) : base(message)
        {
        }
    }
}