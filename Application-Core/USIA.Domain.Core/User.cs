﻿using AltV.Net;
using AltV.Net.Elements.Entities;

namespace USIA.Domain.Core
{
    public class User : Player
    {
        public static readonly uint NicknameMaxLength = 32;
        public bool LoggedIn { get; set; }
        public User(ICore core, IntPtr nativePointer, uint id) : base(core, nativePointer, id)
        {
            LoggedIn = false;
        }
    }

    public class UserFactory : IEntityFactory<IPlayer>
    {
        public IPlayer Create(ICore core, IntPtr playerPointer, uint id)
        {
            return new User(core, playerPointer, id);
        }
    }
}
