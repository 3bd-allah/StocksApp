import OrderList from "./OrderList";

const BuyOrders = ({ pages, isLoading, fetchNextPage, hasNextPage, isLoadingNextPage }) => {
  return (
    <>
      <OrderList
        pages={pages}
        title={"Buy Orders"}
        isLoading={isLoading}
        hasNextPage={hasNextPage}
        onLoadMore={fetchNextPage}
        isLoadingNextPage={isLoadingNextPage}
      />
    </>
  );
};

export default BuyOrders;
