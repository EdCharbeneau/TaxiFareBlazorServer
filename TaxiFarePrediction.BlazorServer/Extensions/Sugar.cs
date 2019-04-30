using System;

namespace TaxiFarePrediction.BlazorServer.Extensions
{
    public static class Sugar
    {
        public static TResult Map<TSource, TResult>(this TSource @this,Func<TSource, TResult> fn) =>
            fn(@this);
    }
}
