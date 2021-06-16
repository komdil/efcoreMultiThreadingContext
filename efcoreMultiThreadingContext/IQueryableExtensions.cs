using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Linq
{
    public static class IQueryableExtensions
    {
        #region MyRegion

        //
        // Summary:
        //     Applies an accumulator function over a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to aggregate over.
        //
        //   func:
        //     An accumulator function to be invoked on each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The final accumulator value.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or func is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static TSource Aggregate<TSource>(this IQueryable<TSource> source, Func<TSource, TSource, TSource> func)
        {
            lock (source.Provider)
            {
                return Enumerable.Aggregate(source, func);
            }
        }

        //
        // Summary:
        //     Applies an accumulator function over a sequence. The specified seed value is
        //     used as the initial accumulator value.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to aggregate over.
        //
        //   seed:
        //     The initial accumulator value.
        //
        //   func:
        //     An accumulator function to be invoked on each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TAccumulate:
        //     The type of the accumulator value.
        //
        // Returns:
        //     The final accumulator value.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or func is null.
        public static TAccumulate Aggregate<TSource, TAccumulate>(this IQueryable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
        {
            lock (source.Provider)
            {
                return Enumerable.Aggregate(source, seed, func);
            }
        }

        //
        // Summary:
        //     Applies an accumulator function over a sequence. The specified seed value is
        //     used as the initial accumulator value, and the specified function is used to
        //     select the result value.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to aggregate over.
        //
        //   seed:
        //     The initial accumulator value.
        //
        //   func:
        //     An accumulator function to be invoked on each element.
        //
        //   resultSelector:
        //     A function to transform the final accumulator value into the result value.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TAccumulate:
        //     The type of the accumulator value.
        //
        //   TResult:
        //     The type of the resulting value.
        //
        // Returns:
        //     The transformed final accumulator value.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or func or resultSelector is null.
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this IQueryable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            lock (source.Provider)
            {
                return Enumerable.Aggregate(source, seed, func, resultSelector);
            }
        }

        //
        // Summary:
        //     Determines whether all elements of a sequence satisfy a condition.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements to apply
        //     the predicate to.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     true if every element of the source sequence passes the test in the specified
        //     predicate, or if the sequence is empty; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static bool All<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.All(source, predicate);
            }
        }

        //
        // Summary:
        //     Determines whether a sequence contains any elements.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to check for emptiness.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     true if the source sequence contains any elements; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static bool Any<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Any(source);
            }
        }

        //
        // Summary:
        //     Determines whether any element of a sequence satisfies a condition.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 whose elements to apply the predicate
        //     to.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     true if the source sequence is not empty and at least one of its elements passes
        //     the test in the specified predicate; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static bool Any<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.Any(source, predicate);
            }
        }

        //
        // Summary:
        //     Appends a value to the end of the sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values.
        //
        //   element:
        //     The value to append to source.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A new sequence that ends with element.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource> Append<TSource>(this IQueryable<TSource> source, TSource element)
        {
            lock (source.Provider)
            {
                return Enumerable.Append(source, element);
            }
        }

        //
        // Summary:
        //     Returns the input typed as System.Collections.Generic.IEnumerable`1.
        //
        // Parameters:
        //   source:
        //     The sequence to type as System.Collections.Generic.IEnumerable`1.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The input sequence typed as System.Collections.Generic.IEnumerable`1.
        public static IEnumerable<TSource> AsEnumerable<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.AsEnumerable(source);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of System.Int32 values that are obtained by
        //     invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The average of the sequence of values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        //
        //   T:System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double Average<TSource>(this IQueryable<TSource> source, Func<TSource, int> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source, selector);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of System.Int64 values that are obtained by
        //     invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The average of the sequence of values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        //
        //   T:System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double Average<TSource>(this IQueryable<TSource> source, Func<TSource, long> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source, selector);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of nullable System.Decimal values that are
        //     obtained by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The average of the sequence of values, or null if the source sequence is empty
        //     or contains only values that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Decimal.MaxValue.
        public static decimal? Average<TSource>(this IQueryable<TSource> source, Func<TSource, decimal?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source, selector);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of System.Single values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The average of the sequence of values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static float Average<TSource>(this IQueryable<TSource> source, Func<TSource, float> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source, selector);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of nullable System.Int32 values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The average of the sequence of values, or null if the source sequence is empty
        //     or contains only values that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double? Average<TSource>(this IQueryable<TSource> source, Func<TSource, int?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source, selector);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of nullable System.Single values that are
        //     obtained by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The average of the sequence of values, or null if the source sequence is empty
        //     or contains only values that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static float? Average<TSource>(this IQueryable<TSource> source, Func<TSource, float?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source, selector);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of System.Double values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The average of the sequence of values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static double Average<TSource>(this IQueryable<TSource> source, Func<TSource, double> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source, selector);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of nullable System.Double values that are
        //     obtained by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The average of the sequence of values, or null if the source sequence is empty
        //     or contains only values that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static double? Average<TSource>(this IQueryable<TSource> source, Func<TSource, double?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source, selector);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of System.Decimal values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate an average.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The average of the sequence of values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        //
        //   T:System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Decimal.MaxValue.
        public static decimal Average<TSource>(this IQueryable<TSource> source, Func<TSource, decimal> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source, selector);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of nullable System.Int64 values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the average of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The average of the sequence of values, or null if the source sequence is empty
        //     or contains only values that are null.
        public static double? Average<TSource>(this IQueryable<TSource> source, Func<TSource, long?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source, selector);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of nullable System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Single values to calculate the average of.
        //
        // Returns:
        //     The average of the sequence of values, or null if the source sequence is empty
        //     or contains only values that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static float? Average(this IQueryable<float?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Decimal values to calculate the average of.
        //
        // Returns:
        //     The average of the sequence of values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static decimal Average(this IQueryable<decimal> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int32 values to calculate the average of.
        //
        // Returns:
        //     The average of the sequence of values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static double Average(this IQueryable<int> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int64 values to calculate the average of.
        //
        // Returns:
        //     The average of the sequence of values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static double Average(this IQueryable<long> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Double values to calculate the average of.
        //
        // Returns:
        //     The average of the sequence of values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static double Average(this IQueryable<double> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of nullable System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Double values to calculate the average of.
        //
        // Returns:
        //     The average of the sequence of values, or null if the source sequence is empty
        //     or contains only values that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static double? Average(this IQueryable<double?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of nullable System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int32 values to calculate the average of.
        //
        // Returns:
        //     The average of the sequence of values, or null if the source sequence is empty
        //     or contains only values that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double? Average(this IQueryable<int?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of nullable System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int64 values to calculate the average of.
        //
        // Returns:
        //     The average of the sequence of values, or null if the source sequence is empty
        //     or contains only values that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double? Average(this IQueryable<long?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of nullable System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Decimal values to calculate the average of.
        //
        // Returns:
        //     The average of the sequence of values, or null if the source sequence is empty
        //     or contains only values that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Decimal.MaxValue.
        public static decimal? Average(this IQueryable<decimal?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source);
            }
        }

        //
        // Summary:
        //     Computes the average of a sequence of System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Single values to calculate the average of.
        //
        // Returns:
        //     The average of the sequence of values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static float Average(this IQueryable<float> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Average(source);
            }
        }

        //
        // Summary:
        //     Casts the elements of an System.Collections.IEnumerable to the specified type.
        //
        // Parameters:
        //   source:
        //     The System.Collections.IEnumerable that contains the elements to be cast to type
        //     TResult.
        //
        // Type parameters:
        //   TResult:
        //     The type to cast the elements of source to.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains each element of the
        //     source sequence cast to the specified type.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidCastException:
        //     An element in the sequence cannot be cast to type TResult.
        public static IEnumerable<TResult> Cast<TResult>(this IQueryable source)
        {
            lock (source.Provider)
            {
                return Enumerable.Cast<TResult>(source);
            }
        }

        //
        // Summary:
        //     Determines whether a sequence contains a specified element by using the default
        //     equality comparer.
        //
        // Parameters:
        //   source:
        //     A sequence in which to locate a value.
        //
        //   value:
        //     The value to locate in the sequence.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     true if the source sequence contains an element that has the specified value;
        //     otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static bool Contains<TSource>(this IQueryable<TSource> source, TSource value)
        {
            lock (source.Provider)
            {
                return Enumerable.Contains(source, value);
            }
        }

        //
        // Summary:
        //     Determines whether a sequence contains a specified element by using a specified
        //     System.Collections.Generic.IEqualityComparer`1.
        //
        // Parameters:
        //   source:
        //     A sequence in which to locate a value.
        //
        //   value:
        //     The value to locate in the sequence.
        //
        //   comparer:
        //     An equality comparer to compare values.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     true if the source sequence contains an element that has the specified value;
        //     otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static bool Contains<TSource>(this IQueryable<TSource> source, TSource value, IEqualityComparer<TSource>? comparer)
        {
            lock (source.Provider)
            {
                return Enumerable.Contains(source, value, comparer);
            }
        }

        //
        // Summary:
        //     Returns a number that represents how many elements in the specified sequence
        //     satisfy a condition.
        //
        // Parameters:
        //   source:
        //     A sequence that contains elements to be tested and counted.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A number that represents how many elements in the sequence satisfy the condition
        //     in the predicate function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.OverflowException:
        //     The number of elements in source is larger than System.Int32.MaxValue.
        public static int Count<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.Count(source, predicate);
            }
        }

        //
        // Summary:
        //     Returns the number of elements in a sequence.
        //
        // Parameters:
        //   source:
        //     A sequence that contains elements to be counted.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The number of elements in the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The number of elements in source is larger than System.Int32.MaxValue.
        public static int Count<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Count(source);
            }
        }

        //
        // Summary:
        //     Returns the elements of the specified sequence or the specified value in a singleton
        //     collection if the sequence is empty.
        //
        // Parameters:
        //   source:
        //     The sequence to return the specified value for if it is empty.
        //
        //   defaultValue:
        //     The value to return if the sequence is empty.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains defaultValue if source
        //     is empty; otherwise, source.
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IQueryable<TSource> source, TSource defaultValue)
        {
            lock (source.Provider)
            {
                return Enumerable.DefaultIfEmpty(source, defaultValue);
            }
        }

        //
        // Summary:
        //     Returns the elements of the specified sequence or the type parameter's default
        //     value in a singleton collection if the sequence is empty.
        //
        // Parameters:
        //   source:
        //     The sequence to return a default value for if it is empty.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 object that contains the default
        //     value for the TSource type if source is empty; otherwise, source.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource?> DefaultIfEmpty<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.DefaultIfEmpty(source);
            }
        }

        //
        // Summary:
        //     Returns distinct elements from a sequence by using the default equality comparer
        //     to compare values.
        //
        // Parameters:
        //   source:
        //     The sequence to remove duplicate elements from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains distinct elements from
        //     the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource> Distinct<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Distinct(source);
            }
        }

        //
        // Summary:
        //     Returns distinct elements from a sequence by using a specified System.Collections.Generic.IEqualityComparer`1
        //     to compare values.
        //
        // Parameters:
        //   source:
        //     The sequence to remove duplicate elements from.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare values.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains distinct elements from
        //     the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource> Distinct<TSource>(this IQueryable<TSource> source, IEqualityComparer<TSource>? comparer)
        {
            lock (source.Provider)
            {
                return Enumerable.Distinct(source, comparer);
            }
        }

        //
        // Summary:
        //     Returns the element at a specified index in a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   index:
        //     The zero-based index of the element to retrieve.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The element at the specified position in the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than 0 or greater than or equal to the number of elements in source.
        public static TSource ElementAt<TSource>(this IQueryable<TSource> source, int index)
        {
            lock (source.Provider)
            {
                return Enumerable.ElementAt(source, index);
            }
        }

        //
        // Summary:
        //     Returns the element at a specified index in a sequence or a default value if
        //     the index is out of range.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   index:
        //     The zero-based index of the element to retrieve.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if the index is outside the bounds of the source sequence; otherwise,
        //     the element at the specified position in the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static TSource? ElementAtOrDefault<TSource>(this IQueryable<TSource> source, int index)
        {
            lock (source.Provider)
            {
                return Enumerable.ElementAtOrDefault(source, index);
            }
        }

        //
        // Summary:
        //     Returns the first element of a sequence.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to return the first element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The first element in the specified sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     The source sequence is empty.
        public static TSource First<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.First(source);
            }
        }
        //
        // Summary:
        //     Returns the first element in a sequence that satisfies a specified condition.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The first element in the sequence that passes the test in the specified predicate
        //     function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     No element satisfies the condition in predicate. -or- The source sequence is
        //     empty.
        public static TSource First<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.First(source, predicate);
            }
        }

        //
        // Summary:
        //     Returns the first element of a sequence, or a default value if the sequence contains
        //     no elements.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to return the first element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if source is empty; otherwise, the first element in source.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static TSource? FirstOrDefault<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.FirstOrDefault(source);
            }
        }

        //
        // Summary:
        //     Returns the first element of the sequence that satisfies a condition or a default
        //     value if no such element is found.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if source is empty or if no element passes the test specified
        //     by predicate; otherwise, the first element in source that passes the test specified
        //     by predicate.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static TSource? FirstOrDefault<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.FirstOrDefault(source, predicate);
            }
        }

        //
        // Summary:
        //     Groups the elements of a sequence according to a specified key selector function
        //     and creates a result value from each group and its key. Key values are compared
        //     by using a specified comparer, and the elements of each group are projected by
        //     using a specified function.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 whose elements to group.
        //
        //   keySelector:
        //     A function to extract the key for each element.
        //
        //   elementSelector:
        //     A function to map each source element to an element in an System.Linq.IGrouping`2.
        //
        //   resultSelector:
        //     A function to create a result value from each group.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys with.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the elements in each System.Linq.IGrouping`2.
        //
        //   TResult:
        //     The type of the result value returned by resultSelector.
        //
        // Returns:
        //     A collection of elements of type TResult where each element represents a projection
        //     over a group and its key.
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey>? comparer)
        {
            lock (source.Provider)
            {
                return Enumerable.GroupBy(source, keySelector, elementSelector, resultSelector, comparer);
            }
        }

        //
        // Summary:
        //     Groups the elements of a sequence according to a specified key selector function
        //     and creates a result value from each group and its key. The elements of each
        //     group are projected by using a specified function.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 whose elements to group.
        //
        //   keySelector:
        //     A function to extract the key for each element.
        //
        //   elementSelector:
        //     A function to map each source element to an element in an System.Linq.IGrouping`2.
        //
        //   resultSelector:
        //     A function to create a result value from each group.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the elements in each System.Linq.IGrouping`2.
        //
        //   TResult:
        //     The type of the result value returned by resultSelector.
        //
        // Returns:
        //     A collection of elements of type TResult where each element represents a projection
        //     over a group and its key.
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
            lock (source.Provider)
            {
                return Enumerable.GroupBy(source, keySelector, elementSelector, resultSelector);
            }
        }
        //
        // Summary:
        //     Groups the elements of a sequence according to a specified key selector function
        //     and creates a result value from each group and its key. The keys are compared
        //     by using a specified comparer.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 whose elements to group.
        //
        //   keySelector:
        //     A function to extract the key for each element.
        //
        //   resultSelector:
        //     A function to create a result value from each group.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys with.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TResult:
        //     The type of the result value returned by resultSelector.
        //
        // Returns:
        //     A collection of elements of type TResult where each element represents a projection
        //     over a group and its key.
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey>? comparer)
        {
            lock (source.Provider)
            {
                return Enumerable.GroupBy(source, keySelector, resultSelector, comparer);
            }
        }
        //
        // Summary:
        //     Groups the elements of a sequence according to a specified key selector function
        //     and creates a result value from each group and its key.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 whose elements to group.
        //
        //   keySelector:
        //     A function to extract the key for each element.
        //
        //   resultSelector:
        //     A function to create a result value from each group.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TResult:
        //     The type of the result value returned by resultSelector.
        //
        // Returns:
        //     A collection of elements of type TResult where each element represents a projection
        //     over a group and its key.
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
            lock (source.Provider)
            {
                return Enumerable.GroupBy(source, keySelector, resultSelector);
            }
        }

        //
        // Summary:
        //     Groups the elements of a sequence according to a specified key selector function
        //     and projects the elements for each group by using a specified function.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 whose elements to group.
        //
        //   keySelector:
        //     A function to extract the key for each element.
        //
        //   elementSelector:
        //     A function to map each source element to an element in the System.Linq.IGrouping`2.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the elements in the System.Linq.IGrouping`2.
        //
        // Returns:
        //     An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        //     TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        //     a collection of objects of type TElement and a key.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector or elementSelector is null.
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
            lock (source.Provider)
            {
                return Enumerable.GroupBy(source, keySelector, elementSelector);
            }
        }
        //
        // Summary:
        //     Groups the elements of a sequence according to a specified key selector function
        //     and compares the keys by using a specified comparer.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 whose elements to group.
        //
        //   keySelector:
        //     A function to extract the key for each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        //     TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        //     a collection of objects and a key.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null.
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey>? comparer)
        {
            lock (source.Provider)
            {
                return Enumerable.GroupBy(source, keySelector, comparer);
            }
        }

        //
        // Summary:
        //     Groups the elements of a sequence according to a specified key selector function.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 whose elements to group.
        //
        //   keySelector:
        //     A function to extract the key for each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        //     TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        //     a sequence of objects and a key.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null.
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector)
        {
            lock (source.Provider)
            {
                return Enumerable.GroupBy(source, keySelector);
            }
        }
        //
        // Summary:
        //     Groups the elements of a sequence according to a key selector function. The keys
        //     are compared by using a comparer and each group's elements are projected by using
        //     a specified function.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 whose elements to group.
        //
        //   keySelector:
        //     A function to extract the key for each element.
        //
        //   elementSelector:
        //     A function to map each source element to an element in an System.Linq.IGrouping`2.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the elements in the System.Linq.IGrouping`2.
        //
        // Returns:
        //     An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        //     TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        //     a collection of objects of type TElement and a key.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector or elementSelector is null.
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey>? comparer)
        {
            lock (source.Provider)
            {
                return Enumerable.GroupBy(source, keySelector, elementSelector, comparer);
            }
        }

        //
        // Summary:
        //     Returns the last element of a sequence that satisfies a specified condition.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The last element in the sequence that passes the test in the specified predicate
        //     function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     No element satisfies the condition in predicate. -or- The source sequence is
        //     empty.
        public static TSource Last<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.Last(source, predicate);
            }
        }
        //
        // Summary:
        //     Returns the last element of a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return the last element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value at the last position in the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     The source sequence is empty.
        public static TSource Last<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Last(source);
            }
        }
        //
        // Summary:
        //     Returns the last element of a sequence, or a default value if the sequence contains
        //     no elements.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return the last element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if the source sequence is empty; otherwise, the last element
        //     in the System.Collections.Generic.IEnumerable`1.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static TSource? LastOrDefault<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.LastOrDefault(source);
            }
        }
        //
        // Summary:
        //     Returns the last element of a sequence that satisfies a condition or a default
        //     value if no such element is found.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if the sequence is empty or if no elements pass the test in
        //     the predicate function; otherwise, the last element that passes the test in the
        //     predicate function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static TSource? LastOrDefault<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.LastOrDefault(source, predicate);
            }
        }
        //
        // Summary:
        //     Returns an System.Int64 that represents the total number of elements in a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements to be
        //     counted.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The number of elements in the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The number of elements exceeds System.Int64.MaxValue.
        public static long LongCount<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.LongCount(source);
            }
        }
        //
        // Summary:
        //     Returns an System.Int64 that represents how many elements in a sequence satisfy
        //     a condition.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements to be
        //     counted.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A number that represents how many elements in the sequence satisfy the condition
        //     in the predicate function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.OverflowException:
        //     The number of matching elements exceeds System.Int64.MaxValue.
        public static long LongCount<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.LongCount(source, predicate);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the maximum
        //     nullable System.Double value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        //     that corresponds to the maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static double? Max<TSource>(this IQueryable<TSource> source, Func<TSource, double?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the maximum
        //     System.Int64 value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static long Max<TSource>(this IQueryable<TSource> source, Func<TSource, long> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the maximum
        //     nullable System.Decimal value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        //     that corresponds to the maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static decimal? Max<TSource>(this IQueryable<TSource> source, Func<TSource, decimal?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source, selector);
            }
        }

        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the maximum
        //     nullable System.Int32 value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        //     that corresponds to the maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static int? Max<TSource>(this IQueryable<TSource> source, Func<TSource, int?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source, selector);
            }
        }

        //
        // Summary:
        //     Returns the maximum value in a sequence of nullable System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Single values to determine the maximum value of.
        //
        // Returns:
        //     A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        //     that corresponds to the maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static float? Max(this IQueryable<float?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source);
            }
        }

        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the maximum
        //     nullable System.Single value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        //     that corresponds to the maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static float? Max<TSource>(this IQueryable<TSource> source, Func<TSource, float?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the maximum
        //     System.Single value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static float Max<TSource>(this IQueryable<TSource> source, Func<TSource, float> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a generic sequence and returns
        //     the maximum resulting value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the value returned by selector.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static TResult? Max<TSource, TResult>(this IQueryable<TSource> source, Func<TSource, TResult> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the maximum
        //     System.Int32 value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static int Max<TSource>(this IQueryable<TSource> source, Func<TSource, int> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the maximum
        //     nullable System.Int64 value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        //     that corresponds to the maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static long? Max<TSource>(this IQueryable<TSource> source, Func<TSource, long?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the maximum
        //     System.Double value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static double Max<TSource>(this IQueryable<TSource> source, Func<TSource, double> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source, selector);
            }
        }
        //
        // Summary:
        //     Returns the maximum value in a sequence of nullable System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Double values to determine the maximum value of.
        //
        // Returns:
        //     A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        //     that corresponds to the maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static double? Max(this IQueryable<double?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source);
            }
        }
        //
        // Summary:
        //     Returns the maximum value in a generic sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.ArgumentException:
        //     No object in source implements the System.IComparable or System.IComparable`1
        //     interface.
        public static TSource? Max<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source);
            }
        }
        //
        // Summary:
        //     Returns the maximum value in a sequence of System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Single values to determine the maximum value of.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static float Max(this IQueryable<float> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source);
            }
        }
        //
        // Summary:
        //     Returns the maximum value in a sequence of nullable System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int64 values to determine the maximum value of.
        //
        // Returns:
        //     A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        //     corresponds to the maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static long? Max(this IQueryable<long?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source);
            }
        }
        //
        // Summary:
        //     Returns the maximum value in a sequence of nullable System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int32 values to determine the maximum value of.
        //
        // Returns:
        //     A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        //     corresponds to the maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static int? Max(this IQueryable<int?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source);
            }
        }
        //
        // Summary:
        //     Returns the maximum value in a sequence of nullable System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Decimal values to determine the maximum value of.
        //
        // Returns:
        //     A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        //     that corresponds to the maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static decimal? Max(this IQueryable<decimal?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source);
            }
        }
        //
        // Summary:
        //     Returns the maximum value in a sequence of System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int64 values to determine the maximum value of.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static long Max(this IQueryable<long> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source);
            }
        }

        //
        // Summary:
        //     Returns the maximum value in a sequence of System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int32 values to determine the maximum value of.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static int Max(this IQueryable<int> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source);
            }
        }
        //
        // Summary:
        //     Returns the maximum value in a sequence of System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Double values to determine the maximum value of.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static double Max(this IQueryable<double> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source);
            }
        }
        //
        // Summary:
        //     Returns the maximum value in a sequence of System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Decimal values to determine the maximum value of.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static decimal Max(this IQueryable<decimal> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the maximum
        //     System.Decimal value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the maximum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The maximum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static decimal Max<TSource>(this IQueryable<TSource> source, Func<TSource, decimal> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Max(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the minimum
        //     nullable System.Decimal value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        //     that corresponds to the minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static decimal? Min<TSource>(this IQueryable<TSource> source, Func<TSource, decimal?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the minimum
        //     System.Int32 value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static int Min<TSource>(this IQueryable<TSource> source, Func<TSource, int> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the minimum
        //     System.Int64 value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static long Min<TSource>(this IQueryable<TSource> source, Func<TSource, long> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the minimum
        //     nullable System.Double value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        //     that corresponds to the minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static double? Min<TSource>(this IQueryable<TSource> source, Func<TSource, double?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the minimum
        //     System.Double value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static double Min<TSource>(this IQueryable<TSource> source, Func<TSource, double> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the minimum
        //     nullable System.Int64 value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        //     that corresponds to the minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static long? Min<TSource>(this IQueryable<TSource> source, Func<TSource, long?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the minimum
        //     nullable System.Single value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        //     that corresponds to the minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static float? Min<TSource>(this IQueryable<TSource> source, Func<TSource, float?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the minimum
        //     System.Single value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static float Min<TSource>(this IQueryable<TSource> source, Func<TSource, float> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a generic sequence and returns
        //     the minimum resulting value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the value returned by selector.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static TResult? Min<TSource, TResult>(this IQueryable<TSource> source, Func<TSource, TResult> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the minimum
        //     nullable System.Int32 value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        //     that corresponds to the minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static int? Min<TSource>(this IQueryable<TSource> source, Func<TSource, int?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source, selector);
            }
        }
        //
        // Summary:
        //     Invokes a transform function on each element of a sequence and returns the minimum
        //     System.Decimal value.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static decimal Min<TSource>(this IQueryable<TSource> source, Func<TSource, decimal> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source, selector);
            }
        }
        //
        // Summary:
        //     Returns the minimum value in a sequence of System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Double values to determine the minimum value of.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static double Min(this IQueryable<double> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source);
            }
        }
        //
        // Summary:
        //     Returns the minimum value in a sequence of System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Single values to determine the minimum value of.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static float Min(this IQueryable<float> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source);
            }
        }
        //
        // Summary:
        //     Returns the minimum value in a sequence of nullable System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Single values to determine the minimum value of.
        //
        // Returns:
        //     A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        //     that corresponds to the minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static float? Min(this IQueryable<float?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source);
            }
        }
        //
        // Summary:
        //     Returns the minimum value in a sequence of nullable System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int64 values to determine the minimum value of.
        //
        // Returns:
        //     A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        //     corresponds to the minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static long? Min(this IQueryable<long?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source);
            }
        }
        //
        // Summary:
        //     Returns the minimum value in a sequence of nullable System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int32 values to determine the minimum value of.
        //
        // Returns:
        //     A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        //     corresponds to the minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static int? Min(this IQueryable<int?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source);
            }
        }
        //
        // Summary:
        //     Returns the minimum value in a sequence of nullable System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Double values to determine the minimum value of.
        //
        // Returns:
        //     A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        //     that corresponds to the minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static double? Min(this IQueryable<double?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source);
            }
        }
        //
        // Summary:
        //     Returns the minimum value in a sequence of nullable System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Decimal values to determine the minimum value of.
        //
        // Returns:
        //     A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        //     that corresponds to the minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static decimal? Min(this IQueryable<decimal?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source);
            }
        }
        //
        // Summary:
        //     Returns the minimum value in a sequence of System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int64 values to determine the minimum value of.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static long Min(this IQueryable<long> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source);
            }
        }
        //
        // Summary:
        //     Returns the minimum value in a sequence of System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int32 values to determine the minimum value of.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static int Min(this IQueryable<int> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source);
            }
        }
        //
        // Summary:
        //     Returns the minimum value in a generic sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to determine the minimum value of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.ArgumentException:
        //     No object in source implements the System.IComparable or System.IComparable`1
        //     interface.
        public static TSource? Min<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source);
            }
        }
        //
        // Summary:
        //     Returns the minimum value in a sequence of System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Decimal values to determine the minimum value of.
        //
        // Returns:
        //     The minimum value in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     source contains no elements.
        public static decimal Min(this IQueryable<decimal> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Min(source);
            }
        }

        //
        // Summary:
        //     Sorts the elements of a sequence in ascending order according to a key.
        //
        // Parameters:
        //   source:
        //     A sequence of values to order.
        //
        //   keySelector:
        //     A function to extract a key from an element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        //     key.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null.
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector)
        {
            lock (source.Provider)
            {
                return Enumerable.OrderBy(source, keySelector);
            }
        }
        //
        // Summary:
        //     Sorts the elements of a sequence in ascending order by using a specified comparer.
        //
        // Parameters:
        //   source:
        //     A sequence of values to order.
        //
        //   keySelector:
        //     A function to extract a key from an element.
        //
        //   comparer:
        //     An System.Collections.Generic.IComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        //     key.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null.
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer)
        {
            lock (source.Provider)
            {
                return Enumerable.OrderBy(source, keySelector, comparer);
            }
        }
        //
        // Summary:
        //     Sorts the elements of a sequence in descending order according to a key.
        //
        // Parameters:
        //   source:
        //     A sequence of values to order.
        //
        //   keySelector:
        //     A function to extract a key from an element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        //     according to a key.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null.
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector)
        {
            lock (source.Provider)
            {
                return Enumerable.OrderByDescending(source, keySelector);
            }
        }
        //
        // Summary:
        //     Sorts the elements of a sequence in descending order by using a specified comparer.
        //
        // Parameters:
        //   source:
        //     A sequence of values to order.
        //
        //   keySelector:
        //     A function to extract a key from an element.
        //
        //   comparer:
        //     An System.Collections.Generic.IComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        //     according to a key.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null.
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer)
        {
            lock (source.Provider)
            {
                return Enumerable.OrderByDescending(source, keySelector, comparer);
            }
        }
        //
        // Summary:
        //     Adds a value to the beginning of the sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values.
        //
        //   element:
        //     The value to prepend to source.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A new sequence that begins with element.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource> Prepend<TSource>(this IQueryable<TSource> source, TSource element)
        {
            lock (source.Provider)
            {
                return Enumerable.Prepend(source, element);
            }
        }

        //
        // Summary:
        //     Inverts the order of the elements in a sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to reverse.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A sequence whose elements correspond to those of the input sequence in reverse
        //     order.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource> Reverse<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Reverse(source);
            }
        }
        //
        // Summary:
        //     Projects each element of a sequence into a new form.
        //
        // Parameters:
        //   source:
        //     A sequence of values to invoke a transform function on.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the value returned by selector.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 whose elements are the result of
        //     invoking the transform function on each element of source.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static IEnumerable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Func<TSource, TResult> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Select(source, selector);
            }
        }
        //
        // Summary:
        //     Projects each element of a sequence into a new form by incorporating the element's
        //     index.
        //
        // Parameters:
        //   source:
        //     A sequence of values to invoke a transform function on.
        //
        //   selector:
        //     A transform function to apply to each source element; the second parameter of
        //     the function represents the index of the source element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the value returned by selector.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 whose elements are the result of
        //     invoking the transform function on each element of source.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static IEnumerable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Func<TSource, int, TResult> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Select(source, selector);
            }
        }
        //
        // Summary:
        //     Projects each element of a sequence to an System.Collections.Generic.IEnumerable`1,
        //     flattens the resulting sequences into one sequence, and invokes a result selector
        //     function on each element therein. The index of each source element is used in
        //     the intermediate projected form of that element.
        //
        // Parameters:
        //   source:
        //     A sequence of values to project.
        //
        //   collectionSelector:
        //     A transform function to apply to each source element; the second parameter of
        //     the function represents the index of the source element.
        //
        //   resultSelector:
        //     A transform function to apply to each element of the intermediate sequence.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TCollection:
        //     The type of the intermediate elements collected by collectionSelector.
        //
        //   TResult:
        //     The type of the elements of the resulting sequence.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 whose elements are the result of
        //     invoking the one-to-many transform function collectionSelector on each element
        //     of source and then mapping each of those sequence elements and their corresponding
        //     source element to a result element.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or collectionSelector or resultSelector is null.
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IQueryable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        {
            lock (source.Provider)
            {
                return Enumerable.SelectMany(source, collectionSelector, resultSelector);
            }
        }
        //
        // Summary:
        //     Projects each element of a sequence to an System.Collections.Generic.IEnumerable`1,
        //     and flattens the resulting sequences into one sequence. The index of each source
        //     element is used in the projected form of that element.
        //
        // Parameters:
        //   source:
        //     A sequence of values to project.
        //
        //   selector:
        //     A transform function to apply to each source element; the second parameter of
        //     the function represents the index of the source element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the elements of the sequence returned by selector.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 whose elements are the result of
        //     invoking the one-to-many transform function on each element of an input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IQueryable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.SelectMany(source, selector);
            }
        }
        //
        // Summary:
        //     Projects each element of a sequence to an System.Collections.Generic.IEnumerable`1
        //     and flattens the resulting sequences into one sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to project.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the elements of the sequence returned by selector.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 whose elements are the result of
        //     invoking the one-to-many transform function on each element of the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IQueryable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.SelectMany(source, selector);
            }
        }
        //
        // Summary:
        //     Projects each element of a sequence to an System.Collections.Generic.IEnumerable`1,
        //     flattens the resulting sequences into one sequence, and invokes a result selector
        //     function on each element therein.
        //
        // Parameters:
        //   source:
        //     A sequence of values to project.
        //
        //   collectionSelector:
        //     A transform function to apply to each element of the input sequence.
        //
        //   resultSelector:
        //     A transform function to apply to each element of the intermediate sequence.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TCollection:
        //     The type of the intermediate elements collected by collectionSelector.
        //
        //   TResult:
        //     The type of the elements of the resulting sequence.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 whose elements are the result of
        //     invoking the one-to-many transform function collectionSelector on each element
        //     of source and then mapping each of those sequence elements and their corresponding
        //     source element to a result element.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or collectionSelector or resultSelector is null.
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IQueryable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        {
            lock (source.Provider)
            {
                return Enumerable.SelectMany(source, collectionSelector, resultSelector);
            }
        }

        //
        // Summary:
        //     Returns the only element of a sequence that satisfies a specified condition,
        //     and throws an exception if more than one such element exists.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return a single element from.
        //
        //   predicate:
        //     A function to test an element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The single element of the input sequence that satisfies a condition.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     No element satisfies the condition in predicate. -or- More than one element satisfies
        //     the condition in predicate. -or- The source sequence is empty.
        public static TSource Single<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.Single(source, predicate);
            }
        }
        //
        // Summary:
        //     Returns the only element of a sequence, and throws an exception if there is not
        //     exactly one element in the sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return the single element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The single element of the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     The input sequence contains more than one element. -or- The input sequence is
        //     empty.
        public static TSource Single<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Single(source);
            }
        }
        //
        // Summary:
        //     Returns the only element of a sequence, or a default value if the sequence is
        //     empty; this method throws an exception if there is more than one element in the
        //     sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return the single element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The single element of the input sequence, or default(TSource) if the sequence
        //     contains no elements.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     The input sequence contains more than one element.
        public static TSource? SingleOrDefault<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Single(source);
            }
        }
        //
        // Summary:
        //     Returns the only element of a sequence that satisfies a specified condition or
        //     a default value if no such element exists; this method throws an exception if
        //     more than one element satisfies the condition.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return a single element from.
        //
        //   predicate:
        //     A function to test an element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The single element of the input sequence that satisfies the condition, or default(TSource)
        //     if no such element is found.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     More than one element satisfies the condition in predicate.
        public static TSource? SingleOrDefault<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.SingleOrDefault(source, predicate);
            }
        }
        //
        // Summary:
        //     Bypasses a specified number of elements in a sequence and then returns the remaining
        //     elements.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return elements from.
        //
        //   count:
        //     The number of elements to skip before returning the remaining elements.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements that occur
        //     after the specified index in the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource> Skip<TSource>(this IQueryable<TSource> source, int count)
        {
            lock (source.Provider)
            {
                return Enumerable.Skip(source, count);
            }
        }
        //
        // Summary:
        //     Returns a new enumerable collection that contains the elements from source with
        //     the last count elements of the source collection omitted.
        //
        // Parameters:
        //   source:
        //     An enumerable collection instance.
        //
        //   count:
        //     The number of elements to omit from the end of the collection.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements in the enumerable collection.
        //
        // Returns:
        //     A new enumerable collection that contains the elements from source minus count
        //     elements from the end of the collection.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource> SkipLast<TSource>(this IQueryable<TSource> source, int count)
        {
            lock (source.Provider)
            {
                return Enumerable.SkipLast(source, count);
            }
        }
        //
        // Summary:
        //     Bypasses elements in a sequence as long as a specified condition is true and
        //     then returns the remaining elements. The element's index is used in the logic
        //     of the predicate function.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return elements from.
        //
        //   predicate:
        //     A function to test each source element for a condition; the second parameter
        //     of the function represents the index of the source element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements from the
        //     input sequence starting at the first element in the linear series that does not
        //     pass the test specified by predicate.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static IEnumerable<TSource> SkipWhile<TSource>(this IQueryable<TSource> source, Func<TSource, int, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.SkipWhile(source, predicate);
            }
        }
        //
        // Summary:
        //     Bypasses elements in a sequence as long as a specified condition is true and
        //     then returns the remaining elements.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return elements from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements from the
        //     input sequence starting at the first element in the linear series that does not
        //     pass the test specified by predicate.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static IEnumerable<TSource> SkipWhile<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.SkipWhile(source, predicate);
            }
        }
        //
        // Summary:
        //     Computes the sum of the sequence of System.Single values that are obtained by
        //     invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate a sum.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The sum of the projected values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static float Sum<TSource>(this IQueryable<TSource> source, Func<TSource, float> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source, selector);
            }
        }
        //
        // Summary:
        //     Computes the sum of the sequence of System.Int32 values that are obtained by
        //     invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate a sum.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The sum of the projected values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Int32.MaxValue.
        public static int Sum<TSource>(this IQueryable<TSource> source, Func<TSource, int> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source, selector);
            }
        }
        //
        // Summary:
        //     Computes the sum of the sequence of System.Int64 values that are obtained by
        //     invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate a sum.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The sum of the projected values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Int64.MaxValue.
        public static long Sum<TSource>(this IQueryable<TSource> source, Func<TSource, long> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source, selector);
            }
        }
        //
        // Summary:
        //     Computes the sum of the sequence of nullable System.Decimal values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate a sum.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The sum of the projected values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Decimal.MaxValue.
        public static decimal? Sum<TSource>(this IQueryable<TSource> source, Func<TSource, decimal?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source, selector);
            }
        }
        //
        // Summary:
        //     Computes the sum of the sequence of System.Double values that are obtained by
        //     invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate a sum.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The sum of the projected values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static double Sum<TSource>(this IQueryable<TSource> source, Func<TSource, double> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source, selector);
            }
        }
        //
        // Summary:
        //     Computes the sum of the sequence of nullable System.Int32 values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate a sum.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The sum of the projected values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Int32.MaxValue.
        public static int? Sum<TSource>(this IQueryable<TSource> source, Func<TSource, int?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source, selector);
            }
        }
        //
        // Summary:
        //     Computes the sum of the sequence of nullable System.Int64 values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate a sum.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The sum of the projected values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Int64.MaxValue.
        public static long? Sum<TSource>(this IQueryable<TSource> source, Func<TSource, long?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source, selector);
            }
        }
        //
        // Summary:
        //     Computes the sum of the sequence of nullable System.Single values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate a sum.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The sum of the projected values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static float? Sum<TSource>(this IQueryable<TSource> source, Func<TSource, float?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source, selector);
            }
        }
        //
        // Summary:
        //     Computes the sum of the sequence of nullable System.Double values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate a sum.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The sum of the projected values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        public static double? Sum<TSource>(this IQueryable<TSource> source, Func<TSource, double?> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source, selector);
            }
        }
        //
        // Summary:
        //     Computes the sum of the sequence of System.Decimal values that are obtained by
        //     invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate a sum.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The sum of the projected values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or selector is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Decimal.MaxValue.
        public static decimal Sum<TSource>(this IQueryable<TSource> source, Func<TSource, decimal> selector)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source, selector);
            }
        }
        //
        // Summary:
        //     Computes the sum of a sequence of nullable System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Double values to calculate the sum of.
        //
        // Returns:
        //     The sum of the values in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static double? Sum(this IQueryable<double?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source);
            }
        }
        //
        // Summary:
        //     Computes the sum of a sequence of nullable System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Single values to calculate the sum of.
        //
        // Returns:
        //     The sum of the values in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static float? Sum(this IQueryable<float?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source);
            }
        }
        //
        // Summary:
        //     Computes the sum of a sequence of System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Decimal values to calculate the sum of.
        //
        // Returns:
        //     The sum of the values in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Decimal.MaxValue.
        public static decimal Sum(this IQueryable<decimal> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source);
            }
        }
        //
        // Summary:
        //     Computes the sum of a sequence of System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Double values to calculate the sum of.
        //
        // Returns:
        //     The sum of the values in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static double Sum(this IQueryable<double> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source);
            }
        }
        //
        // Summary:
        //     Computes the sum of a sequence of System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int32 values to calculate the sum of.
        //
        // Returns:
        //     The sum of the values in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Int32.MaxValue.
        public static int Sum(this IQueryable<int> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source);
            }
        }
        //
        // Summary:
        //     Computes the sum of a sequence of System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Single values to calculate the sum of.
        //
        // Returns:
        //     The sum of the values in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static float Sum(this IQueryable<float> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source);
            }
        }
        //
        // Summary:
        //     Computes the sum of a sequence of nullable System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Decimal values to calculate the sum of.
        //
        // Returns:
        //     The sum of the values in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Decimal.MaxValue.
        public static decimal? Sum(this IQueryable<decimal?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source);
            }
        }
        //
        // Summary:
        //     Computes the sum of a sequence of nullable System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int32 values to calculate the sum of.
        //
        // Returns:
        //     The sum of the values in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Int32.MaxValue.
        public static int? Sum(this IQueryable<int?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source);
            }
        }
        //
        // Summary:
        //     Computes the sum of a sequence of nullable System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int64 values to calculate the sum of.
        //
        // Returns:
        //     The sum of the values in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Int64.MaxValue.
        public static long? Sum(this IQueryable<long?> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source);
            }
        }
        //
        // Summary:
        //     Computes the sum of a sequence of System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int64 values to calculate the sum of.
        //
        // Returns:
        //     The sum of the values in the sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.OverflowException:
        //     The sum is larger than System.Int64.MaxValue.
        public static long Sum(this IQueryable<long> source)
        {
            lock (source.Provider)
            {
                return Enumerable.Sum(source);
            }
        }
        //
        // Summary:
        //     Returns a specified number of contiguous elements from the start of a sequence.
        //
        // Parameters:
        //   source:
        //     The sequence to return elements from.
        //
        //   count:
        //     The number of elements to return.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains the specified number
        //     of elements from the start of the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource> Take<TSource>(this IQueryable<TSource> source, int count)
        {
            lock (source.Provider)
            {
                return Enumerable.Take(source, count);
            }
        }
        //
        // Summary:
        //     Returns a new enumerable collection that contains the last count elements from
        //     source.
        //
        // Parameters:
        //   source:
        //     An enumerable collection instance.
        //
        //   count:
        //     The number of elements to take from the end of the collection.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements in the enumerable collection.
        //
        // Returns:
        //     A new enumerable collection that contains the last count elements from source.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static IEnumerable<TSource> TakeLast<TSource>(this IQueryable<TSource> source, int count)
        {
            lock (source.Provider)
            {
                return Enumerable.TakeLast(source, count);
            }
        }
        //
        // Summary:
        //     Returns elements from a sequence as long as a specified condition is true.
        //
        // Parameters:
        //   source:
        //     A sequence to return elements from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains the elements from the
        //     input sequence that occur before the element at which the test no longer passes.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static IEnumerable<TSource> TakeWhile<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.TakeWhile(source, predicate);
            }
        }
        //
        // Summary:
        //     Returns elements from a sequence as long as a specified condition is true. The
        //     element's index is used in the logic of the predicate function.
        //
        // Parameters:
        //   source:
        //     The sequence to return elements from.
        //
        //   predicate:
        //     A function to test each source element for a condition; the second parameter
        //     of the function represents the index of the source element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 that contains elements from the input
        //     sequence that occur before the element at which the test no longer passes.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static IEnumerable<TSource> TakeWhile<TSource>(this IQueryable<TSource> source, Func<TSource, int, bool> predicate)
        {
            lock (source.Provider)
            {
                return Enumerable.TakeWhile(source, predicate);
            }
        }

        //
        // Summary:
        //     Creates an array from a System.Collections.Generic.IEnumerable`1.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create an array from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An array that contains the elements from the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static TSource[] ToArray<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.ToArray(source);
            }
        }
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.Dictionary`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     A System.Collections.Generic.Dictionary`2 that contains keys and values. The
        //     values within each group are in the same order as in source.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null. -or- keySelector produces a key that is null.
        //
        //   T:System.ArgumentException:
        //     keySelector produces duplicate keys for two elements.
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector) where TKey : notnull
        {
            lock (source.Provider)
            {
                return Enumerable.ToDictionary(source, keySelector);
            }
        }
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function and key comparer.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.Dictionary`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the keys returned by keySelector.
        //
        // Returns:
        //     A System.Collections.Generic.Dictionary`2 that contains keys and values. The
        //     values within each group are in the same order as in source.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null. -or- keySelector produces a key that is null.
        //
        //   T:System.ArgumentException:
        //     keySelector produces duplicate keys for two elements.
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey>? comparer) where TKey : notnull
        {
            lock (source.Provider)
            {
                return Enumerable.ToDictionary(source, keySelector, comparer);
            }
        }
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary`2 from an System.Collections.Generic.IEnumerable`1
        //     according to specified key selector and element selector functions.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.Dictionary`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        //     selected from the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector or elementSelector is null. -or- keySelector produces a
        //     key that is null.
        //
        //   T:System.ArgumentException:
        //     keySelector produces duplicate keys for two elements.
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) where TKey : notnull
        {
            lock (source.Provider)
            {
                return Enumerable.ToDictionary(source, keySelector, elementSelector);
            }
        }
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function, a comparer, and an element selector
        //     function.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.Dictionary`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        //     selected from the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector or elementSelector is null. -or- keySelector produces a
        //     key that is null.
        //
        //   T:System.ArgumentException:
        //     keySelector produces duplicate keys for two elements.
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey>? comparer) where TKey : notnull
        {
            lock (source.Provider)
            {
                return Enumerable.ToDictionary(source, keySelector, elementSelector, comparer);
            }
        }
        //
        // Summary:
        //     Creates a System.Collections.Generic.HashSet`1 from an System.Collections.Generic.IEnumerable`1.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.HashSet`1
        //     from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A System.Collections.Generic.HashSet`1 that contains values of type TSource selected
        //     from the input sequence.
        public static HashSet<TSource> ToHashSet<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.ToHashSet(source);
            }
        }
        //
        // Summary:
        //     Creates a System.Collections.Generic.HashSet`1 from an System.Collections.Generic.IEnumerable`1
        //     using the comparer to compare keys.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.HashSet`1
        //     from.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A System.Collections.Generic.HashSet`1 that contains values of type TSource selected
        //     from the input sequence.
        public static HashSet<TSource> ToHashSet<TSource>(this IQueryable<TSource> source, IEqualityComparer<TSource>? comparer)
        {
            lock (source.Provider)
            {
                return Enumerable.ToHashSet(source, comparer);
            }
        }

        //
        // Summary:
        //     Creates a System.Linq.Lookup`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function, a comparer and an element selector
        //     function.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to create a System.Linq.Lookup`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A System.Linq.Lookup`2 that contains values of type TElement selected from the
        //     input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector or elementSelector is null.
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey>? comparer)
        {
            lock (source.Provider)
            {
                return Enumerable.ToLookup(source, keySelector, elementSelector, comparer);
            }
        }
        //
        // Summary:
        //     Creates a System.Linq.Lookup`2 from an System.Collections.Generic.IEnumerable`1
        //     according to specified key selector and element selector functions.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to create a System.Linq.Lookup`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A System.Linq.Lookup`2 that contains values of type TElement selected from the
        //     input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector or elementSelector is null.
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
            lock (source.Provider)
            {
                return Enumerable.ToLookup(source, keySelector, elementSelector);
            }
        }
        //
        // Summary:
        //     Creates a System.Linq.Lookup`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function and key comparer.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to create a System.Linq.Lookup`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     A System.Linq.Lookup`2 that contains keys and values. The values within each
        //     group are in the same order as in source.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null.
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey>? comparer)
        {
            lock (source.Provider)
            {
                return Enumerable.ToLookup(source, keySelector, comparer);
            }
        }
        //
        // Summary:
        //     Creates a System.Linq.Lookup`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to create a System.Linq.Lookup`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     A System.Linq.Lookup`2 that contains keys and values. The values within each
        //     group are in the same order as in source.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null.
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IQueryable<TSource> source, Func<TSource, TKey> keySelector)
        {
            lock (source.Provider)
            {
                return Enumerable.ToLookup(source, keySelector);
            }
        }

       
        //
        // Summary:
        //     Creates a System.Collections.Generic.List`1 from an System.Collections.Generic.IEnumerable`1.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.List`1
        //     from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A System.Collections.Generic.List`1 that contains elements from the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static List<TSource> ToList<TSource>(this IQueryable<TSource> source)
        {
            lock (source.Provider)
            {
                return Enumerable.ToList(source);
            }
        }

        #endregion
    }
}
