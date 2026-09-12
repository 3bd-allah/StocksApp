import OrderCard from "./OrderCard";

const OrderList = ({
  title,
  pages = [],
  isLoading,
  hasNextPage,
  onLoadMore,
  isLoadingNextPage,
}) => {

  const orders = pages?.flatMap((page) => page?.items) ?? [];

  return (
    <div className="w-full bg-gray-50/80 border border-gray-300 rounded-lg p-6 shadow-sm min-h-[400px]">
      <h2 className="text-gray-600 font-semibold text-sm mb-5">{title}</h2>

      {isLoading ? (
        <div className="text-gray-400 text-sm py-8 text-center">
          Loading orders...
        </div>
      ) : orders.length === 0 ? (
        <div className="text-gray-400 text-sm py-8 text-center">
          No orders available.
        </div>
      ) : (
        <div className="flex flex-col gap-5">
          {orders?.map((order) => (
            <OrderCard
              key={order.buyOrderID || order.sellOrderID }
              order={order}
            />
          ))}
        </div>
      )}
      {hasNextPage && (
        <button
          onClick={onLoadMore}
          className="mt-6 w-full py-2.5 px-4 text-sm font-medium text-gray-700 bg-white border border-gray-300 rounded-md shadow-sm hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-gray-500 disabled:opacity-50 disabled:cursor-not-allowed transition-colors cursor-pointer"
        >
          {isLoadingNextPage
            ? "Loading more..."
            : hasNextPage
              ? "Load more"
              : "No more orders"}
        </button>
      )}
    </div>
  );
};

export default OrderList;
