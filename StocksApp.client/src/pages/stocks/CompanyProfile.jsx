import { Link, useLocation, useNavigate } from "react-router";
import { useState } from "react";
import { useMutation } from "@tanstack/react-query";
import { createSellOrder, createBuyOrder } from "../../api/stocks";
import toast from "react-hot-toast";

const CompanyProfile = () => {
  const [quantity, setQuantity] = useState();
  const location = useLocation();
  const navigate = useNavigate();
  const company = location.state;

  // these action should be protected ( user should login first )
  const {
    mutate: createBuy,
    data: buyOrderResponse,
    isPending: isCreatingBuyOrder,
  } = useMutation({
    mutationFn: createBuyOrder,
    onSuccess: () => {
      toast.success("Buy order created successfully");
      navigate("/stocks/orders");
    },
    onError: () => {
      toast.error("Something went wrong \n please try again later!");
    },
  });

  console.log(buyOrderResponse);
  const {
    mutate: createSell,
    data: sellOrderResponse,
    isPending: isCreatingSellOrder,
  } = useMutation({
    mutationFn: createSellOrder,
    onSuccess: () => {
      toast.success("Sell order created successfully");
      navigate("/stocks/orders");
    },
    onError: () => {
      toast.error("Something went wrong \n please try again later!");
    },
  });

  console.log(sellOrderResponse);

  function handleBuy(stockData) {
    console.log("from buy handler");
    const buyOrderData = {
      stockSymbol: stockData.stockSymbol,
      stockName: stockData.stockName,
      price: stockData.price,
      quantity,
    };
    const { signal } = new AbortController();
    createBuy({ signal, buyOrderData });
  }

  function handleSell(stockData) {
    console.log("from sell handler");
    const sellOrderData = {
      stockSymbol: stockData.stockSymbol,
      stockName: stockData.stockName,
      price: stockData.price,
      quantity,
    };
    const { signal } = new AbortController();
    createSell({ signal, sellOrderData });
  }

  return (
    <>
      {!company ? (
        <div className="flex flex-col items-center justify-center min-h-[60vh] gap-3 text-center">
          <h4 className="text-gray-600 font-semibold text-lg">
            No Stock selected to trade on.
          </h4>
          <Link
            to="/stocks/explore"
            className="bg-blue-600 hover:bg-blue-700 text-white text-sm font-medium px-4 py-2 rounded transition-colors"
          >
            Go to Stocks
          </Link>
        </div>
      ) : (
        <div className="w-full border border-gray-300 rounded-lg p-6 bg-gray-50 flex flex-col md:flex-row justify-between items-center shadow-sm">
          {/* Left Section: Company Info */}
          <div className="mb-6 md:mb-0">
            <h2 className="text-2xl font-bold text-blue-600 inline">
              {company.stockName}{" "}
            </h2>
            <span className="text-2xl font-bold text-blue-600">
              ({company.stockSymbol})
            </span>

            <div className="mt-2 text-5xl font-extrabold text-gray-900">
              <span className="text-gray-400 font-normal mr-1">$</span>
              {company.price.toFixed(2)}
            </div>
          </div>

          {/* Vertical Divider */}
          <div className="hidden md:block w-px bg-gray-300 h-28 mx-6" />

          {/* Right Section: Order Action Form */}
          <div className="flex flex-col items-center min-w-[180px]">
            <h3 className="text-gray-600 font-semibold mb-3">New Order</h3>

            <div className="flex flex-col items-center mb-4">
              <label htmlFor="quantity" className="text-sm text-gray-600 mb-1">
                Quantity:
              </label>
              <input
                id="quantity"
                type="number"
                min={1}
                max={10000}
                defaultValue={company.quantity}
                value={quantity}
                onChange={(e) => setQuantity(e.target.value)}
                className="w-50 px-2 py-1 text-center border border-gray-300 rounded bg-white focus:outline-none focus:ring-2 focus:ring-blue-500"
              />
            </div>

            {/* Action Buttons */}
            <div className="flex gap-3">
              <button
                disabled={isCreatingSellOrder}
                onClick={() => handleSell(company)}
                className="flex items-center gap-1 bg-red-700 hover:bg-red-800 text-white font-medium px-4 py-1.5 rounded transition-colors cursor-pointer"
              >
                {isCreatingSellOrder ? "Pending..." : <span>↓ Sell</span>}
              </button>

              <button
                disabled={isCreatingBuyOrder}
                onClick={() => handleBuy(company)}
                className="flex items-center gap-1 bg-green-700 hover:bg-green-800 text-white font-medium px-4 py-1.5 rounded transition-colors cursor-pointer"
              >
                {isCreatingBuyOrder ? "Pending..." : <span>↑ Buy</span>}
              </button>
            </div>
          </div>
        </div>
      )}
    </>
  );
};

export default CompanyProfile;
