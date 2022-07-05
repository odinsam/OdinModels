using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdinModels.Core.Entities;
using SqlSugar;

namespace OdinModels.Core.Repositories
{
    public class Repository<T> : SimpleClient<T> where T : class, new()
    {
        public Repository(ISqlSugarClient context = null) : base(context) //注意这里要有默认值等于null
        {
            base.Context=context;//ioc注入的对象
            // base.Context=DbScoped.SugarScope; SqlSugar.Ioc这样写
            // base.Context=DbHelper.GetDbInstance()当然也可以手动去赋值
        }
 
        /// <summary>
        /// 扩展方法，自带方法不能满足的时候可以添加新方法
        /// </summary>
        /// <returns></returns>
        public List<T> CommQuery(string json)
        {
            //base.Context.Queryable<T>().ToList();可以拿到SqlSugarClient 做复杂操作
            return null;
        }
     
    }
}