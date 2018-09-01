using System;
using System.Collections.Generic;
using System.Linq;

using SEDC.PracticalAspNet.Business.Model;
using SEDC.PracticalAspNet.Data.Model;
using SEDC.PracticalAspNet.Data.Repository;

namespace SEDC.PracticalAspNet.Business.Service
{
    public class MenuService : BaseService<MenuRepository>, IService<DtoMenu>
    {
        public ServiceResult<DtoMenu> Add(DtoMenu item)
        {
            try
            {
                var result = Repository.Create(new Menu()
                {
                    TypeId = (byte)item.TypeEnum,
                    RestaurantName = item.RestaurantName
                });
                return new ServiceResult<DtoMenu>()
                {
                    Item = new DtoMenu(result),
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log exception
                return new ServiceResult<DtoMenu>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoMenu> Edit(DtoMenu item)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DtoMenu> Load(DtoMenu item)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DtoMenu> LoadAll()
        {
            try
            {
                var menus = Repository.GetAll().ToList();
                var resultList = new List<DtoMenu>();
                menus.ForEach(m => resultList.Add(new DtoMenu(m)));
                return new ServiceResult<DtoMenu>()
                {
                    ListItems = resultList,
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log exception
                return new ServiceResult<DtoMenu>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoMenu> Remove(DtoMenu item)
        {
            throw new NotImplementedException();
        }
    }
}
