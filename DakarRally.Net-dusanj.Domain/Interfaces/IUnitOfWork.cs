using System;
using System.Collections.Generic;
using System.Text;

namespace DakarRally.Net_dusanj.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }
}
