using System.Collections.Generic;

namespace BethanysPieShop.Models {
    public class CategoryRepository : ICategoryRepository {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext) {
            this._appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
    }
}