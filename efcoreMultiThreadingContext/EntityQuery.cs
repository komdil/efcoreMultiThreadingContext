using System.Collections.Generic;
using System.Linq.Expressions;
namespace System.Linq
{

    public static class EntityQueryExtensions
    {

        //
        // Summary:
        //     Returns the number of elements in a sequence.
        //
        // Parameters:
        //   source.Query:
        //     The System.Linq.IQueryable`1 that contains the elements to be counted.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     The number of elements in the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query is null.
        //
        //   T:System.OverflowException:
        //     The number of elements in source.Query is larger than System.Int32.MaxValue.
        public static int Count<TSource>(this EntityQuery<TSource> source)
        {
            lock (source.Query.Provider)
            {
                return Queryable.Count(source.Query);
            }
        }
        //
        // Summary:
        //     Returns the number of elements in the specified sequence that satisfies a condition.
        //
        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 that contains the elements to be counted.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     The number of elements in the sequence that satisfies the condition in the predicate
        //     function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or predicate is null.
        //
        //   T:System.OverflowException:
        //     The number of elements in source.Query is larger than System.Int32.MaxValue.
        public static int Count<TSource>(this EntityQuery<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            lock (source.Query.Provider)
            {
                return Queryable.Count(source.Query, predicate);
            }
        }

        //
        // Summary:
        //     Returns the first element of a sequence.
        //
        // Parameters:
        //   source.Query:
        //     The System.Linq.IQueryable`1 to return the first element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     The first element in source.Query.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query is null.
        //
        //   T:System.InvalidOperationException:
        //     The source.Query sequence is empty.
        public static TSource First<TSource>(this EntityQuery<TSource> source)
        {
            lock (source.Query.Provider)
            {
                return Queryable.First(source.Query);
            }
        }
        //
        // Summary:
        //     Returns the first element of a sequence that satisfies a specified condition.
        //
        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     The first element in source.Query that passes the test in predicate.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     No element satisfies the condition in predicate. -or- The source.Query sequence is
        //     empty.
        public static TSource First<TSource>(this EntityQuery<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            lock (source.Query.Provider)
            {
                return Queryable.First(source.Query, predicate);
            }
        }
        //
        // Summary:
        //     Returns the first element of a sequence, or a default value if the sequence contains
        //     no elements.
        //
        // Parameters:
        //   source.Query:
        //     The System.Linq.IQueryable`1 to return the first element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     default(TSource) if source.Query is empty; otherwise, the first element in source.Query.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query is null.
        public static TSource? FirstOrDefault<TSource>(this EntityQuery<TSource> source)
        {
            lock (source.Query.Provider)
            {
                return Queryable.FirstOrDefault(source.Query);
            }
        }
        //
        // Summary:
        //     Returns the first element of a sequence that satisfies a specified condition
        //     or a default value if no such element is found.
        //
        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     default(TSource) if source.Query is empty or if no element passes the test specified
        //     by predicate; otherwise, the first element in source.Query that passes the test specified
        //     by predicate.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or predicate is null.
        public static TSource? FirstOrDefault<TSource>(this EntityQuery<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            lock (source.Query.Provider)
            {
                return Queryable.FirstOrDefault(source.Query, predicate);
            }
        }

        //
        // Summary:
        //     Returns the last element of a sequence that satisfies a specified condition.
        //
        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     The last element in source.Query that passes the test specified by predicate.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     No element satisfies the condition in predicate. -or- The source.Query sequence is
        //     empty.
        public static TSource Last<TSource>(this EntityQuery<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            lock (source.Query.Provider)
            {
                return Queryable.Last(source.Query, predicate);
            }
        }
        //
        // Summary:
        //     Returns the last element in a sequence.
        //
        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 to return the last element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     The value at the last position in source.Query.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query is null.
        //
        //   T:System.InvalidOperationException:
        //     The source.Query sequence is empty.
        public static TSource Last<TSource>(this EntityQuery<TSource> source)
        {
            lock (source.Query.Provider)
            {
                return Queryable.Last(source.Query);
            }
        }
        //
        // Summary:
        //     Returns the last element in a sequence, or a default value if the sequence contains
        //     no elements.
        //
        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 to return the last element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     default(TSource) if source.Query is empty; otherwise, the last element in source.Query.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query is null.
        public static TSource? LastOrDefault<TSource>(this EntityQuery<TSource> source)
        {
            lock (source.Query.Provider)
            {
                return Queryable.LastOrDefault(source.Query);
            }
        }
        //
        // Summary:
        //     Returns the last element of a sequence that satisfies a condition or a default
        //     value if no such element is found.
        //
        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     default(TSource) if source.Query is empty or if no elements pass the test in the predicate
        //     function; otherwise, the last element of source.Query that passes the test in the predicate
        //     function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or predicate is null.
        public static TSource? LastOrDefault<TSource>(this EntityQuery<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            lock (source.Query.Provider)
            {
                return Queryable.LastOrDefault(source.Query, predicate);
            }
        }

        //
        // Summary:
        //     Projects each element of a sequence into a new form.
        //
        // Parameters:
        //   source.Query:
        //     A sequence of values to project.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        //   TResult:
        //     The type of the value returned by the function represented by selector.
        //
        // Returns:
        //     An System.Linq.IQueryable`1 whose elements are the result of invoking a projection
        //     function on each element of source.Query.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or selector is null.
        public static IQueryable<TResult> Select<TSource, TResult>(this EntityQuery<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            lock (source.Query.Provider)
            {
                return Queryable.Select(source.Query, selector);
            }
        }
        //
        // Summary:
        //     Projects each element of a sequence into a new form by incorporating the element's
        //     index.
        //
        // Parameters:
        //   source.Query:
        //     A sequence of values to project.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        //   TResult:
        //     The type of the value returned by the function represented by selector.
        //
        // Returns:
        //     An System.Linq.IQueryable`1 whose elements are the result of invoking a projection
        //     function on each element of source.Query.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or selector is null.
        public static IQueryable<TResult> Select<TSource, TResult>(this EntityQuery<TSource> source, Expression<Func<TSource, int, TResult>> selector)
        {
            lock (source.Query.Provider)
            {
                return Queryable.Select(source.Query, selector);
            }
        }
        //
        // Summary:
        //     Projects each element of a sequence to an System.Collections.Generic.IEnumerable`1
        //     that incorporates the index of the source.Query element that produced it. A result
        //     selector function is invoked on each element of each intermediate sequence, and
        //     the resulting values are combined into a single, one-dimensional sequence and
        //     returned.
        //
        // Parameters:
        //   source.Query:
        //     A sequence of values to project.
        //
        //   collectionSelector:
        //     A projection function to apply to each element of the input sequence; the second
        //     parameter of this function represents the index of the source.Query element.
        //
        //   resultSelector:
        //     A projection function to apply to each element of each intermediate sequence.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        //   TCollection:
        //     The type of the intermediate elements collected by the function represented by
        //     collectionSelector.
        //
        //   TResult:
        //     The type of the elements of the resulting sequence.
        //
        // Returns:
        //     An System.Linq.IQueryable`1 whose elements are the result of invoking the one-to-many
        //     projection function collectionSelector on each element of source.Query and then mapping
        //     each of those sequence elements and their corresponding source.Query element to a result
        //     element.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or collectionSelector or resultSelector is null.
        public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this EntityQuery<TSource> source, Expression<Func<TSource, int, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector)
        {
            lock (source.Query.Provider)
            {
                return Queryable.SelectMany(source.Query, collectionSelector, resultSelector);
            }
        }
        //
        // Summary:
        //     Projects each element of a sequence to an System.Collections.Generic.IEnumerable`1
        //     and invokes a result selector function on each element therein. The resulting
        //     values from each intermediate sequence are combined into a single, one-dimensional
        //     sequence and returned.
        //
        // Parameters:
        //   source.Query:
        //     A sequence of values to project.
        //
        //   collectionSelector:
        //     A projection function to apply to each element of the input sequence.
        //
        //   resultSelector:
        //     A projection function to apply to each element of each intermediate sequence.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        //   TCollection:
        //     The type of the intermediate elements collected by the function represented by
        //     collectionSelector.
        //
        //   TResult:
        //     The type of the elements of the resulting sequence.
        //
        // Returns:
        //     An System.Linq.IQueryable`1 whose elements are the result of invoking the one-to-many
        //     projection function collectionSelector on each element of source.Query and then mapping
        //     each of those sequence elements and their corresponding source.Query element to a result
        //     element.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or collectionSelector or resultSelector is null.
        public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this EntityQuery<TSource> source, Expression<Func<TSource, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector)
        {
            lock (source.Query.Provider)
            {
                return Queryable.SelectMany(source.Query, collectionSelector, resultSelector);
            }
        }
        //
        // Summary:
        //     Projects each element of a sequence to an System.Collections.Generic.IEnumerable`1
        //     and combines the resulting sequences into one sequence. The index of each source.Query
        //     element is used in the projected form of that element.
        //
        // Parameters:
        //   source.Query:
        //     A sequence of values to project.
        //
        //   selector:
        //     A projection function to apply to each element; the second parameter of this
        //     function represents the index of the source.Query element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        //   TResult:
        //     The type of the elements of the sequence returned by the function represented
        //     by selector.
        //
        // Returns:
        //     An System.Linq.IQueryable`1 whose elements are the result of invoking a one-to-many
        //     projection function on each element of the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or selector is null.
        public static IQueryable<TResult> SelectMany<TSource, TResult>(this EntityQuery<TSource> source, Expression<Func<TSource, int, IEnumerable<TResult>>> selector)
        {
            lock (source.Query.Provider)
            {
                return Queryable.SelectMany(source.Query, selector);
            }
        }
        //
        // Summary:
        //     Projects each element of a sequence to an System.Collections.Generic.IEnumerable`1
        //     and combines the resulting sequences into one sequence.
        //
        // Parameters:
        //   source.Query:
        //     A sequence of values to project.
        //
        //   selector:
        //     A projection function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        //   TResult:
        //     The type of the elements of the sequence returned by the function represented
        //     by selector.
        //
        // Returns:
        //     An System.Linq.IQueryable`1 whose elements are the result of invoking a one-to-many
        //     projection function on each element of the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or selector is null.
        public static IQueryable<TResult> SelectMany<TSource, TResult>(this EntityQuery<TSource> source, Expression<Func<TSource, IEnumerable<TResult>>> selector)
        {
            lock (source.Query.Provider)
            {
                return Queryable.SelectMany(source.Query, selector);
            }
        }

        //
        // Summary:
        //     Returns the only element of a sequence, and throws an exception if there is not
        //     exactly one element in the sequence.
        //
        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 to return the single element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     The single element of the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query is null.
        //
        //   T:System.InvalidOperationException:
        //     source.Query has more than one element.
        public static TSource Single<TSource>(this EntityQuery<TSource> source)
        {
            lock (source.Query.Provider)
            {
                return Queryable.Single(source.Query);
            }
        }
        //
        // Summary:
        //     Returns the only element of a sequence that satisfies a specified condition,
        //     and throws an exception if more than one such element exists.
        //
        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 to return a single element from.
        //
        //   predicate:
        //     A function to test an element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     The single element of the input sequence that satisfies the condition in predicate.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     No element satisfies the condition in predicate. -or- More than one element satisfies
        //     the condition in predicate. -or- The source.Query sequence is empty.
        public static TSource Single<TSource>(this EntityQuery<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            lock (source.Query.Provider)
            {
                return Queryable.Single(source.Query, predicate);
            }
        }
        //
        // Summary:
        //     Returns the only element of a sequence, or a default value if the sequence is
        //     empty; this method throws an exception if there is more than one element in the
        //     sequence.
        //
        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 to return the single element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     The single element of the input sequence, or default(TSource) if the sequence
        //     contains no elements.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query is null.
        //
        //   T:System.InvalidOperationException:
        //     source.Query has more than one element.
        public static TSource? SingleOrDefault<TSource>(this EntityQuery<TSource> source)
        {
            lock (source.Query.Provider)
            {
                return Queryable.SingleOrDefault(source.Query);
            }
        }
        //
        // Summary:
        //     Returns the only element of a sequence that satisfies a specified condition or
        //     a default value if no such element exists; this method throws an exception if
        //     more than one element satisfies the condition.
        //
        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 to return a single element from.
        //
        //   predicate:
        //     A function to test an element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     The single element of the input sequence that satisfies the condition in predicate,
        //     or default(TSource) if no such element is found.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     More than one element satisfies the condition in predicate.
        public static TSource? SingleOrDefault<TSource>(this EntityQuery<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            lock (source.Query.Provider)
            {
                return Queryable.SingleOrDefault(source.Query, predicate);
            }
        }



        //
        // Summary:
        //     Creates a System.Collections.Generic.List`1 from an System.Collections.Generic.IEnumerable`1.
        //
        // Parameters:
        //   source.Query:
        //     The System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.List`1
        //     from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.
        //
        // Returns:
        //     A System.Collections.Generic.List`1 that contains elements from the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query is null.
        public static List<TSource> ToList<TSource>(this EntityQuery<TSource> source)
        {
            lock (source.Query.Provider)
            {
                return Enumerable.ToList(source.Query);
            }
        }


        //Summary:
        //     Filters a sequence of values based on a predicate.

        // Parameters:
        //   source.Query:
        //     An System.Linq.IQueryable`1 to filter.


        //   predicate:
        //     A function to test each element for a condition.


        // Type parameters:
        //   TSource:
        //     The type of the elements of source.Query.

        // Returns:
        //     An System.Linq.IQueryable`1 that contains elements from the input sequence that
        //     satisfy the condition specified by predicate.


        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source.Query or predicate is null.
        public static EntityQuery<T> Where<T>(this EntityQuery<T> source, Expression<Func<T, bool>> predicate)
        {
            lock (source.Query.Provider)
            {
                return new EntityQuery<T>(Queryable.Where(source.Query, predicate));
            }
        }
    }

    public class EntityQuery<T>
    {
        public IQueryable<T> Query { get; set; }

        public EntityQuery(IQueryable<T> query)
        {
            Query = query;
        }
    }

}
