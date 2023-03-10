//=================================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use Comfort and Pease
//==================================================

using Rummage.Api.Controllers.Models.Foundetions;
using System.Threading.Tasks;

namespace Rummage.Api.Broker.Storages
{
    public partial interface IStorageBroker
    {
        // create 
        // Read 
        // Update 
        // Delete
        
      ValueTask <Guest> InsertGuestAsync(Guest guest);   


    }
}
