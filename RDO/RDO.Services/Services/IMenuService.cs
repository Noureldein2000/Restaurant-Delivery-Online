using RDO.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Services.Services
{
    public interface IMenuService
    {
        MenuDTO AddMenu(MenuDTO model);
        List<MenuDTO> GetMenusbyResturantId(int restId);
        MenuDTO GetMenusbyId(int restId);
        MenuDTO EditMenu(MenuDTO model);

    }
}
