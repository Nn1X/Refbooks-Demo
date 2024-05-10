using MediatR;
using Refbooks.Application.Interfaces;

namespace Refbooks.Application.Refbooks.Commands
{
    public class UpdateRefbboksCommandHandler : IRequestHandler<UpdateRefbooksCommand, string[]>
    {
        private readonly IRefbookUpdater _updater;

        public UpdateRefbboksCommandHandler(IRefbookUpdater updater)
        {
            _updater = updater;
        }

        public async Task<string[]> Handle(UpdateRefbooksCommand request, CancellationToken cancellationToken)
        {
            var resultMessages = await _updater.UpdateRefbooksAsync(request.Refbooks);

            return resultMessages.ToArray();
        }
    }
}
