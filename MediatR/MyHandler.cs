using AutoMapper;
using MediatR;

namespace $rootnamespace$;
    
public class $servicename$Handler : IRequestHandler<$servicename$Request, $servicename$Response> {

    private readonly IMapper _mapper;
    private readonly  _dbContext;

    public $servicename$Handler(
        IMapper mapper,
         dbContext
    ) {
        this._mapper = mapper;
        this._dbContext = dbContext;
    }

    public async Task<$servicename$Response> Handle($servicename$Request request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}
