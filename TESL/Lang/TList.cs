using System.Collections.Generic;
using SExpression;

namespace TESL.Lang
{
    public class TList : SExprList
    {
        public TList(IEnumerable<ISExpression> list) : base(list){
            
        }
    }
}