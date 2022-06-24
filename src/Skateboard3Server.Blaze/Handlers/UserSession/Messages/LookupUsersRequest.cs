﻿using System.Collections.Generic;
using MediatR;
using Skateboard3Server.Blaze.Common;
using Skateboard3Server.Blaze.Serializer.Attributes;
using Skateboard3Server.Blaze.Server;

namespace Skateboard3Server.Blaze.Handlers.UserSession.Messages;

[BlazeRequest(BlazeComponent.UserSession, (ushort)UserSessionCommand.LookupUsers)]
public class LookupUsersRequest : BlazeRequest, IRequest<LookupUsersResponse>
{
    [TdfField("LTYP")]
    public UserLookupType LookupType { get; set; }

    [TdfField("ULST")]
    public List<UserInformation> Users { get; set; }
}