using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace NorthwindBackend.Entities.Dtos
{
    public class UserForRegisterDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
    }
}
