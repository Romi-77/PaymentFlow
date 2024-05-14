﻿using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable

namespace Models.Response
{
    public class Response
    {
        /// <summary>
        /// 狀態碼
        /// </summary>
        [DefaultValue(1)]
        [DataMember(Order = 1)]
        public virtual int Code { get; set; } = 1;

        /// <summary>
        /// 訊息
        /// </summary>
        [DataMember(Order = 2)]
        public virtual string Message { get; set; }
    }

    public class Response<T> : Response
    {
        /// <summary>
        /// 資料
        /// </summary>
        [DataMember(Order = 3)]
        public virtual T Data { get; set; }
    }
}
