﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using JCE.Utils.Exceptions;
using JCE.Validations;

namespace JCE.Applications.Dtos
{
    /// <summary>
    /// 请求对象
    /// </summary>
    [DataContract]
    public abstract class RequestBase:IRequest
    {
        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        public virtual ValidationResultCollection Validate()
        {
            var result = DataAnnotationValidation.Validate(this);
            if (result.IsValid)
            {
                return ValidationResultCollection.Success;
            }
            throw new Warning(result.First().ErrorMessage);
        }
    }
}
