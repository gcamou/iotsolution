using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace Core.Abstractions.Extensions
{
    using Core.Abstractions.Biz;
    public static class MapExtensions
    {
        public static async Task<TDestination> ToBizAsync<TSource, TDestination>(this Task<TSource> sourceListTask)
        where TSource : class, new()
        where TDestination : IBiz
        {
            var sourceList = await sourceListTask;
            return Map<TSource, TDestination>(sourceList);
        }
        public static async Task<IEnumerable<TDestination>> ToBizAsync<TSource, TDestination>(this Task<IEnumerable<TSource>> sourceListTask)
        where TSource : class, new()
        where TDestination : IBiz
        {
            var sourceList = await sourceListTask;
            return MapList<TSource, TDestination>(sourceList);
        }
        public static TDestination ToBiz<TSource, TDestination>(this TSource source)
        where TSource : IBiz
        where TDestination : class, new()
        {
            return Map<TSource, TDestination>(source);
        }
        public static TDestination ToEntity<TSource, TDestination>(this TSource source)
        where TSource : IBiz
        where TDestination : class, new()
        {
            return Map<TSource, TDestination>(source);
        }

        public static IEnumerable<TDestination> ToBiz<TSource, TDestination>(this IEnumerable<TSource> sourceList)
        where TSource : class, new()
        where TDestination : IBiz
        {
            return MapList<TSource, TDestination>(sourceList);
        }
        public static IEnumerable<TDestination> ToEntity<TSource, TDestination>(this IEnumerable<TSource> sourceList)
        where TSource : class, new()
        where TDestination : IBiz
        {
            return MapList<TSource, TDestination>(sourceList);
        }


        private static IEnumerable<TDestination> MapList<TSource, TDestination>(IEnumerable<TSource> sourceList)
        {
            try
            {
                if (sourceList == null)
                {
                    throw new ArgumentException(nameof(sourceList));
                }

                var destination = Mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(sourceList);
                return destination;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred when mapping {typeof(TSource).Name} to {typeof(TDestination).Name} : {ex.InnerException}");
            }
        }

        private static TDestination Map<TSource, TDestination>(TSource source)
        {
            try
            {
                if (source == null)
                {
                    return default(TDestination);
                }
                return Mapper.Map<TSource, TDestination>(source);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred when mapping {typeof(TSource).Name} to {typeof(TDestination).Name} : {ex.InnerException}");
            }
        }
    }
}