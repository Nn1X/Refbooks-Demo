using MediatR;

namespace Refbooks.Application.Refbooks.Commands
{
    public class UpdateRefbooksCommand : IRequest<string[]>
    {
        public string[] Refbooks { get; set; }
    }
}
