import toast from "react-hot-toast";
import { downloadOrdersAsPdf, getAllOrders } from "../../api/stocks";
import BuyOrders from "./BuyOrders"
import SellOrders from "./SellOrders"
import { useMutation, useQuery } from "@tanstack/react-query" 

const StocksOrders = () => {

  const {data: allOrders, isLoading: isLoadingOrders} = useQuery({
    queryKey:['orders'],
    queryFn: getAllOrders
  });

  const {mutate: downloadPDF, isPending: isDownloadingPDF} =useMutation({
    mutationKey:['download-orders'],
    mutationFn: downloadOrdersAsPdf,
    onSuccess:()=> toast.success('Orders pdf downloaded successfully'),
    onError:() => toast.error("Error !")
  })

  function onDownloadPDF(){
    console.log('download pdf ')
    const {signal} = new AbortController();
    downloadPDF({signal});
  }
  return (
    <div className="w-full px-8 py-4 font-sans bg-gray-100 min-h-screen">
      {/* Top Action Bar: Download as PDF link */}
      <div className="flex justify-end mb-3">
        <button
          onClick={onDownloadPDF}
          className="text-blue-600 hover:underline text-sm font-medium cursor-pointer"
        >
          {isDownloadingPDF? 'Downloading...':'Download as PDF'}
        </button>
      </div>

      {/* Full-width 2-column Grid */}
      <main className="w-full grid grid-cols-1 md:grid-cols-2 gap-8 items-start">
        <BuyOrders buyOrders={allOrders?.buyOrders} isLoading={isLoadingOrders}/>
        <SellOrders sellOrders={allOrders?.sellOrders} isLoading={isLoadingOrders}  />
      </main>
    </div>

  )
}

export default StocksOrders