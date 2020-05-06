using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.OrganizationManage;
using YiSha.Model.Param.OrganizationManage;
using YiSha.Service.OrganizationManage;

namespace YiSha.Business.OrganizationManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-04-30 15:28
    /// 描 述：测试业务类
    /// </summary>
    public class TextBLL
    {
        private TextService textService = new TextService();

        #region 获取数据
        public async Task<TData<List<TextEntity>>> GetList(TextListParam param)
        {
            TData<List<TextEntity>> obj = new TData<List<TextEntity>>();
            obj.Result = await textService.GetList(param);
            obj.TotalCount = obj.Result.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<TextEntity>>> GetPageList(TextListParam param, Pagination pagination)
        {
            TData<List<TextEntity>> obj = new TData<List<TextEntity>>();
            obj.Result = await textService.GetPageList(param, pagination);
            obj.TotalCount = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<TextEntity>> GetEntity(long id)
        {
            TData<TextEntity> obj = new TData<TextEntity>();
            obj.Result = await textService.GetEntity(id);
            if (obj.Result != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(TextEntity entity)
        {
            TData<string> obj = new TData<string>();
            await textService.SaveForm(entity);
            obj.Result = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await textService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
