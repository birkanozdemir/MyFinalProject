using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // constructor da
        // 1-sadece success döndürülmek isteniyorsa 
        // 2- hem success hem message döndürülmek isteniyorsa this yapısı kullanılır.
        // tek döndürülecek ayrı bir constructor yazılır. Her zaman istenilen veri buraya yazılır.
        // İkisini de döndürmek isteniyorsa iki değişkenli constructor çalışır. this ile diğer 
        // constructor içindeki veri otomatik olarak işleme dahil edilir.
        public Result(bool success, string message) : this(success) 
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
