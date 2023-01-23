using TastePlace.Client.Interfaces;
using TastePlace.Shared.Models;

namespace TastePlace.Client.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient _http;

        public MenuService(HttpClient http)
        {
            _http = http;
        }

        public Task AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task AddMenuGroup(MenuGroup menu)
        {
            throw new NotImplementedException();
        }

        public Task AddMenuItem(MenuItem menu)
        {
            throw new NotImplementedException();
        }

        public Task AddMenuSubGroup(MenuSubGroup menu)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Category[]> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategory(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<MenuGroup> GetMenuGroup(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<MenuGroup[]> GetMenuGroups()
        {
            throw new NotImplementedException();
        }

        public Task<MenuItem> GetMenuItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<MenuItem[]> GetMenuItems()
        {
            throw new NotImplementedException();
        }

        public Task<GroupSubCategoryMenu[]> GetMenus()
        {
            throw new NotImplementedException();
        }

        public Task<MenuSubGroup> GetMenuSubGroup(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<MenuSubGroup[]> GetMenuSubGroups()
        {
            throw new NotImplementedException();
        }

        public Task RemoveMenuGroup(MenuGroup menu)
        {
            throw new NotImplementedException();
        }

        public Task RemoveMenuItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveMenuSubGroup(MenuSubGroup menu)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMenuGroup(MenuGroup menu)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMenuItem(MenuItem menu)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMenuSubGroup(MenuSubGroup menu)
        {
            throw new NotImplementedException();
        }
    }
}
