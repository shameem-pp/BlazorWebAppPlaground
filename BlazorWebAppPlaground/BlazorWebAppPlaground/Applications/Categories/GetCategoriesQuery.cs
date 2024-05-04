using BlazorWebAppPlaground.Applications.Extensions;
using BlazorWebAppPlaground.Infra;
using MediatR;

namespace BlazorWebAppPlaground.Applications.Categories;

public class GetCategoriesQuery : IRequest<IEnumerable<CategoryDto>>
{

}

public class GetCategoriesQueryHandler(AppDbContext _context) : IRequestHandler<GetCategoriesQuery, IEnumerable<CategoryDto>>
{
    public async Task<IEnumerable<CategoryDto>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
       return _context.Categories.Select(c => c.MapToDto());
    }
}
