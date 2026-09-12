import OrderList from "./OrderList";

const SellOrders = ({
  pages,
  isLoading,
  fetchNextPage,
  hasNextPage,
  isLoadingNextPage
}) => {
  return (
    <OrderList
      title= {"Sell Orders"}
      pages= {pages}
      isLoading= {isLoading}
      onLoadMore= {fetchNextPage}
      hasNextPage= {hasNextPage}
      isLoadingNextPage= {isLoadingNextPage}
    />
  );
};

export default SellOrders;
