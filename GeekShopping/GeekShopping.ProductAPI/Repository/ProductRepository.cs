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

        public async Task<ProductVO> Create(ProductVO vo)
        {
            // Convertido para Entidade Product
            Product product = _mapper.Map<Product>(vo);
            // Adicionando 
            _context.Products.Add(product);
            // Salvando
            await _context.SaveChangesAsync();
            // Devolvendo um VO
            return _mapper.Map<ProductVO>(product);
        }
        public async Task<ProductVO> Update(ProductVO vo)
        {
            // Convertido para Entidade Product
            Product product = _mapper.Map<Product>(vo);
            // Alterando
            _context.Products.Update(product);
            // Salvando
            await _context.SaveChangesAsync();
            // Devolvendo um VO
            return _mapper.Map<ProductVO>(product);
        }
        public async Task<bool> Delete(long id)
        {
            try
            {
                // Indo no banco e fazendo o Bind da tabela Products para o Objeto Product
                Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (product == null) return false;
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
