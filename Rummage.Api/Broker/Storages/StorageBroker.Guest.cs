//=================================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use Comfort and Pease
//==================================================

using Microsoft.EntityFrameworkCore;
using Rummage.Api.Controllers.Models.Foundetions;

namespace Rummage.Api.Broker.Storages
{
    public partial class StorageBroker
    {
        public DbSet <Guest> Guests { get; set; }
    }
}
