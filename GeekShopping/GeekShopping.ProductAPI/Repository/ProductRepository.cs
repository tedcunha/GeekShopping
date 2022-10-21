using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(MySQLContext context,
                                 IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            // Indo no banco e fazendo o Bind da tabela Products para o Objeto Product
            List<Product> products = await _context.Products.ToListAsync();
            // Convertendo da Entidade Products para o VO ProductVO
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            // Indo no banco e fazendo o Bind da tabela Products para o Objeto Product
            Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
            // Convertendo da Entidade Products para o VO ProductVO
            return _mapper.Map<ProductVO>(product);
        }

        public Task<ProductVO> Create(ProductVO vo)
        {
            throw new NotImplementedException();
        }
        public Task<ProductVO> Update(ProductVO vo)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
