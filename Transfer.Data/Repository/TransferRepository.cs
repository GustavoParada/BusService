using System.Collections.Generic;
using Transfer.Data.Context;
using Transfer.Domain.Interfaces;
using Transfer.Domain.Models;

namespace Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(TransferLog transferLog)
        {
             _ctx.TransferLog.Add(transferLog);

            _ctx.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLog;
        }
    }
}
