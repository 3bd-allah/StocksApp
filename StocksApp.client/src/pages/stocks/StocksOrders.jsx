import toast from "react-hot-toast";
import {
  downloadOrdersAsPdf,
  getBuyOrdersInPages,
  getSellOrdersInPages,
} from "../../api/stocks";
import BuyOrders from "./BuyOrders";
import SellOrders from "./SellOrders";
import { useInfiniteQuery, useMutation } from "@tanstack/react-query";

const StocksOrders = () => {

 

  const {
    data: buyOrdersData,
    fetchNextPage: fetchBuyOrdersNextPage,
    hasNextPage: isBuyOrdersHasNextPage,
    isLoading: isLoadingBuyOrders,
    isFetchingNextPage
  } = useInfiniteQuery({
    queryKey: ["buy-orders-pages"],
    queryFn: ({ signal, pageParam }) =>
      getBuyOrdersInPages({ signal, nextCursor: pageParam }),
    initialPageParam: null,
    getNextPageParam: (result) => result.cursor,
  });

  const {
    data: sellOrdersData, 
    fetchNextPage: fetchSellOrdersNextPage,
    hasNextPage: isSellOrdersHasNextPage,
    isLoading: isLoadingSellOrders, 
    isFetchingNextPage: isFetchingSellOrdersNextPage
  } = useInfiniteQuery({
    queryKey:['sell-orders-pages'],
    queryFn: ({signal, pageParam})=> getSellOrdersInPages({signal, nextCursor: pageParam}),
    initialPageParam: null,
    getNextPageParam:(lastPage) => lastPage.cursor
  })

  const { mutate: downloadPDF, isPending: isDownloadingPDF } = useMutation({
    mutationKey: ["download-orders"],
    mutationFn: downloadOrdersAsPdf,
    onSuccess: () => toast.success("Orders pdf downloaded successfully"),
    onError: () => toast.error("Error !"),
  });

  function onDownloadPDF() {
    const { signal } = new AbortController();
    downloadPDF({ signal });
  }
  return (
    <div className="w-full px-8 py-4 font-sans bg-gray-100 min-h-screen">
      {/* Top Action Bar: Download as PDF link */}
      <div className="flex justify-end mb-3">
        <button
          onClick={onDownloadPDF}
          className="text-blue-600 hover:underline text-sm font-medium cursor-pointer"
        >
          {isDownloadingPDF ? "Downloading..." : "Download as PDF"}
        </button>
      </div>

      {/* Full-width 2-column Grid */}
      <main className="w-full grid grid-cols-1 md:grid-cols-2 gap-8 items-start">

        <BuyOrders
          pages={buyOrdersData?.pages}
          isLoading={isLoadingBuyOrders}
          fetchNextPage={fetchBuyOrdersNextPage}
          hasNextPage={isBuyOrdersHasNextPage}
          isLoadingNextPage={isFetchingNextPage}
        />

        <SellOrders
          pages= {sellOrdersData?.pages}
          isLoading={isLoadingSellOrders}
          fetchNextPage={fetchSellOrdersNextPage}
          hasNextPage={isSellOrdersHasNextPage}
          isLoadingNextPage= {isFetchingSellOrdersNextPage}
        />
      </main>
    </div>
  );
};

export default StocksOrders;
