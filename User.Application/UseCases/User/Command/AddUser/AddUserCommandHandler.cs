using AutoMapper;
using MediatR;
using User.Application.Services;

namespace User.Application.UseCases.User.Command.AddUser;

public class AddUserCommandHandler(IUserService service, IMapper mapper): IRequestHandler<AddUserCommand, AddUserCommandResult>
{
    public Task<AddUserCommandResult> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}