using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Entity;
using YiSha.Model;
using YiSha.Admin.Web.Controllers;
using YiSha.Entity.OrganizationManage;
using YiSha.Business.OrganizationManage;
using YiSha.Model.Param.OrganizationManage;

namespace YiSha.Admin.Web.Areas.OrganizationManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-04-30 15:28
    /// 描 述：测试控制器类
    /// </summary>
    [Area("OrganizationManage")]
    public class TextController :  BaseController
    {
        private TextBLL textBLL = new TextBLL();

        #region 视图功能
        [AuthorizeFilter("organization:text:view")]
        public ActionResult TextIndex()
        {
            return View();
        }

        public ActionResult TextForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("organization:text:search")]
        public async Task<ActionResult> GetListJson(TextListParam param)
        {
            TData<List<TextEntity>> obj = await textBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("organization:text:search")]
        public async Task<ActionResult> GetPageListJson(TextListParam param, Pagination pagination)
        {
            TData<List<TextEntity>> obj = await textBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<TextEntity> obj = await textBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("organization:text:add,organization:text:edit")]
        public async Task<ActionResult> SaveFormJson(TextEntity entity)
        {
            TData<string> obj = await textBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("organization:text:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await textBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
