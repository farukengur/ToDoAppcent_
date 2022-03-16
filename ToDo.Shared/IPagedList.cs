namespace ToDo.Shared.Contact
{

    using System.Collections.Generic;
    /// <summary>
    /// Provides the interface(s) for paged list of any type.
    /// 为任何类型的分页列表提供接口
    /// </summary>
    /// <typeparam name="T">The type for paging.分页的类型</typeparam>
    public interface IPagedList<T>
    {
        /// <summary>
        /// Gets the index start value.
        /// Dizinin başlangıç değerini alır.
        /// </summary>
        /// <value>The index start value.</value>
        int IndexFrom { get; }
        /// <summary>
        /// Gets the page index (current).
        /// Sayfa Dizinini alır
        /// </summary>
        int PageIndex { get; }
        /// <summary>
        /// Gets the page size.
        /// Sayfa boyutunu alır
        /// </summary>
        int PageSize { get; }
        /// <summary>
        /// Gets the total count of the list of type <typeparamref name="T"/>
        /// 
        /// </summary>
        int TotalCount { get; }
        /// <summary>
        /// Toplam sayfaları alır
        /// 
        /// </summary>
        int TotalPages { get; }
        /// <summary>
        /// Gets the current page items.
        /// Geçerli sayfa itemlarını alır
        /// </summary>
        IList<T> Items { get; }
        /// <summary>
        /// Gets the has previous page.
        /// Önceki sayfayı alır
        /// </summary>
        /// <value>The has previous page.</value>
        bool HasPreviousPage { get; }

        /// <summary>
        /// Gets the has next page.
        /// Sonraki sayfayı alır
        /// 
        /// </summary>
        /// <value>The has next page.</value>
        bool HasNextPage { get; }
    }
}
