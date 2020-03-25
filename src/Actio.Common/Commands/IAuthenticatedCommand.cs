using System;

namespace Actio.Common.Commands
{
    interface IAuthenticatedCommand : ICommand
    {
        Guid UserId { get; set; }
    }
}