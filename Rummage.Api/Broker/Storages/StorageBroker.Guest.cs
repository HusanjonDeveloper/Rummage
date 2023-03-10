//=================================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use Comfort and Pease
//==================================================

using Microsoft.EntityFrameworkCore;
using Rummage.Api.Controllers.Models.Foundetions;
using System.Threading.Tasks;

namespace Rummage.Api.Broker.Storages
{
    public partial class StorageBroker
    {
        public DbSet <Guest> Guests { get; set; }

       public async ValueTask<Guest> InsertGuestAsync(Guest guest)
        {
          using var broker = new StorageBroker(this.configuration);
            await broker.AddRangeAsync(Guests);
            await broker.SaveChangesAsync();

        }
    }
}
