using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X.Util.Repository.ColumnMapperCommon
{
    public class ColumnMapper
    {
        public static void SetMapper<TEntity>()
        {
            //数据库字段名和c#属性名不一致，手动添加映射关系
            SqlMapper.SetTypeMap(typeof(TEntity), new ColumnAttributeTypeMapper<TEntity>());

            //每个需要用到[colmun(Name="")]特性的model，都要在这里添加映射
        }
    }
}
