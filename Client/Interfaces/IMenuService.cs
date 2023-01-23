using TastePlace.Shared.Models;

namespace TastePlace.Client.Interfaces
{
    public interface IMenuService
    {
        Task AddMenuGroup(MenuGroup menu);
        Task UpdateMenuGroup(MenuGroup menu);
        Task RemoveMenuGroup(MenuGroup menu);
        Task<MenuGroup> GetMenuGroup(Guid id);
        Task<MenuGroup[]> GetMenuGroups();
        Task AddMenuSubGroup(MenuSubGroup menu);
        Task UpdateMenuSubGroup(MenuSubGroup menu);
        Task RemoveMenuSubGroup(MenuSubGroup menu);
        Task<MenuSubGroup> GetMenuSubGroup(Guid id);
        Task<MenuSubGroup[]> GetMenuSubGroups();
        Task AddCategory(Category category);
        Task UpdateCategory(Category category);
        Task DeleteCategory(Guid id);
        Task<Category> GetCategory(Guid id);
        Task<Category[]> GetCategories();
        Task AddMenuItem(MenuItem menu);
        Task UpdateMenuItem(MenuItem menu);
        Task RemoveMenuItem(Guid id);
        Task<MenuItem> GetMenuItem(Guid id);
        Task<MenuItem[]> GetMenuItems();        
        Task<GroupSubCategoryMenu[]> GetMenus();        
    }
}
