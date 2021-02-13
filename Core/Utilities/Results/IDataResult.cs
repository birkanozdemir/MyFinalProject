using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // interface başka bir interface i implemente ederse o interface in elemanları da
    // o interface in içine aktarılmış olur
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
