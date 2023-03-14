//=================================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use Comfort and Pease
//==================================================

using System;
using Rummage.Api.Core.Entities.Enums;

namespace Rummage.Api.Controllers.Models.Foundetions
{
    public class Guest
    {
        public Guid id { get; set; }
        public string FristName { get; set; }
        public DateTimeOffset DateOfBrith { get; set; }
        public string  LastName { get; set; }
        public string  Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public GenderType Gendr { get; set; }
    }
}
