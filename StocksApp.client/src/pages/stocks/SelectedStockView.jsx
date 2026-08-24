import { useNavigate } from "react-router";

const SelectedStockView = ({ stock }) => {
  const navigate = useNavigate();
  const currentStock = stock ;

  function handleOnTrade(){
    navigate('/stocks/trade', {
      state: currentStock
    })
  }

  return (
    <div className="w-full bg-white border border-gray-200 rounded-lg p-6 shadow-sm flex flex-col justify-between min-h-[450px]">
      <div>
        {/* Company Logo Container */}
        <div className="w-32 h-32 bg-black rounded-lg flex items-center justify-center p-4 mb-4">
          <img
            src={currentStock.logo}
            alt={`${currentStock.stockSymbol} logo`}
            className="w-full h-full"
          />
        </div>

        {/* Stock Title & Symbol */}
        <h2 className="text-2xl font-bold text-gray-900 mb-2">
          {currentStock.stockSymbol} ({currentStock.stockName})
        </h2>

        {/* Category Badge */}
        <div className="mb-3">
          <span className="inline-block bg-gray-500 text-white text-xs font-semibold px-2.5 py-1 rounded">
            {currentStock.finnhubIndustry}
          </span>
        </div>

        {/* Exchange Information */}
        <div className="flex items-center gap-2 mb-6 text-sm">
          <span className="font-bold text-gray-800">Exchange:</span>
          <span className="bg-gray-500 text-white text-xs font-semibold px-2.5 py-1 rounded">
            {currentStock.exchange}
          </span>
        </div>

        {/* Stock Price Display */}
        <div className="text-5xl font-bold text-gray-900 tracking-tight flex items-baseline gap-1">
          <span className="text-gray-400 font-normal">$</span>
          <span>{currentStock.price.toFixed(2)}</span>
        </div>
      </div>

      {/* Trade Now Button */}
      <div className="mt-8">
        <button
          onClick={handleOnTrade}
          className="cursor-pointer bg-blue-600 hover:bg-blue-700 text-white font-semibold text-sm px-5 py-2.5 rounded shadow-sm transition-colors"
        >
          Trade Now
        </button>
      </div>
    </div>
  );
};

export default SelectedStockView;