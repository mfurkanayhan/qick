﻿using MediatR;
using MFA.Result;

namespace QickServer.Application.Qicks.GetParticipantsByRoomNumber;

internal sealed class GetParticipantsByRoomNumberQueryHandler : IRequestHandler<GetParticipantsByRoomNumberQuery,
    Result<List<Participant>>>
{
    public async Task<Result<List<Participant>>> Handle(GetParticipantsByRoomNumberQuery request, CancellationToken cancellationToken)
    {
        List<Participant> participants = 
            Shared.Participants
            .Where(p => p.RoomNumber == request.RoomNumber)
            .Select(s => s.Participant)
            .ToList();

        await Task.CompletedTask;

        return participants!;
    }
}
