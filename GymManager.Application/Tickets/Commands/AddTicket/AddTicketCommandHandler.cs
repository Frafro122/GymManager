using MediatR;
using Microsoft.Extensions.Logging;

namespace GymManager.Application.Tickets.Commands.AddTicket;
public class AddTicketCommandHandler : IRequestHandler<AddTicketCommand>
{
    private readonly ILogger _logger;

    public AddTicketCommandHandler(ILogger<AddTicketCommandHandler> logger)
    {
        _logger = logger;
    }

    public async Task<Unit> Handle(AddTicketCommand request, CancellationToken cancellationToken)
    {
        //var ticket = new Ticket();
        //ticket.Name = request.Name;
        //zapis

        _logger.LogInformation("dasdasdas");

        return Unit.Value;
    }
}
