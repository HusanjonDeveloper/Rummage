//=================================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use Comfort and Pease
//==================================================

using EFxceptions.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Rummage.Api.Broker.Storages
{
    public partial class StorageBroker : EFxceptionsContext
    {
        public IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectingString =
                this.configuration.GetConnectionString(name: "DefaultConnection");

            optionsBuilder.UseSqlServer(connectingString);
        }

        public override void Dispose() {}

    }
}
