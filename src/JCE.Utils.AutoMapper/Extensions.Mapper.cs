﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using AutoMapper;

namespace JCE.Utils.AutoMapper
{
    /// <summary>
    /// AutoMapper 对象映射扩展
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// 同步锁
        /// </summary>
        private static readonly object Sync=new object();

        /// <summary>
        /// 将源对象映射到目标对象
        /// </summary>
        /// <typeparam name="TSource">源类型</typeparam>
        /// <typeparam name="TDestination">目标类型</typeparam>
        /// <param name="source">源对象</param>
        /// <param name="destination">目标对象</param>
        /// <returns></returns>
        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return MapTo<TDestination>(source, destination);
        }

        /// <summary>
        /// 将源对象映射到目标对象
        /// </summary>
        /// <typeparam name="TDestination">目标类型</typeparam>
        /// <param name="source">源对象</param>
        /// <returns></returns>
        public static TDestination MapTo<TDestination>(this object source) where TDestination : new()
        {
            return MapTo(source, new TDestination());
        }

        /// <summary>
        /// 将源集合映射到目标级别和
        /// </summary>
        /// <typeparam name="TDestination">目标元素类型，范例：Sample，不用加List</typeparam>
        /// <param name="source">源集合</param>
        /// <returns></returns>
        public static List<TDestination> MapToList<TDestination>(this IEnumerable source)
        {
            return MapTo<List<TDestination>>(source);
        }

        /// <summary>
        /// 将源对象映射到目标对象
        /// </summary>
        /// <typeparam name="TDestination">目标类型</typeparam>
        /// <param name="source">源对象</param>
        /// <param name="destination">目标对象</param>
        /// <returns></returns>
        private static TDestination MapTo<TDestination>(object source, TDestination destination)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }
            var sourceType = GetType(source);
            var destinationType = GetType(destination);
            var map = GetMap(sourceType, destinationType);
            if (map != null)
            {
                return Mapper.Map(source, destination);
            }
            lock (Sync)
            {
                map = GetMap(sourceType, destinationType);
                if (map != null)
                {
                    return Mapper.Map(source, destination);
                }
                var maps = Mapper.Configuration.GetAllTypeMaps();
                Mapper.Initialize(config =>
                {
                    foreach (var item in maps)
                    {
                        config.CreateMap(item.SourceType, item.DestinationType);
                    }
                    config.CreateMap(sourceType, destinationType);
                });
            }
            return Mapper.Map(source, destination);
        }

        /// <summary>
        /// 获取映射配置
        /// </summary>
        /// <param name="sourceType">源类型</param>
        /// <param name="destinationType">目标类型</param>
        /// <returns></returns>
        private static TypeMap GetMap(Type sourceType, Type destinationType)
        {
            try
            {
                return Mapper.Configuration.FindTypeMapFor(sourceType, destinationType);
            }
            catch (InvalidOperationException)
            {
                lock (Sync)
                {
                    try
                    {
                        return Mapper.Configuration.FindTypeMapFor(sourceType, destinationType);
                    }
                    catch (InvalidOperationException)
                    {
                        Mapper.Initialize(config =>
                        {
                            config.CreateMap(sourceType, destinationType);
                        });
                    }
                    return Mapper.Configuration.FindTypeMapFor(sourceType, destinationType);
                }
            }
        }

        /// <summary>
        /// 获取类型
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        private static Type GetType(object obj)
        {
            var type = obj.GetType();
            if (obj is System.Collections.IEnumerable == false)
            {
                return type;
            }
            if (type.IsArray)
            {
                return type.GetElementType();
            }
            var genericArgumentsTypes = type.GetTypeInfo().GetGenericArguments();
            if (genericArgumentsTypes == null || genericArgumentsTypes.Length == 0)
            {
                throw new ArgumentException("泛型类型参数不能为空");
            }
            return genericArgumentsTypes[0];
        }
    }
}
