import Loading from "../../components/Loading";

const StocksList = ({ stocks = [] , onSelectStock, isLoading, onRefetch }) => {
  return (
    <div className="w-full bg-gray-50 border border-gray-200 rounded-lg p-4 shadow-sm">
      {/* List Header */}
      <div className="flex justify-between items-center mb-3 px-1">
        <h2 className="text-gray-700 font-semibold text-sm">Stocks</h2>
        <button
          // href=""
          onClick={onRefetch}
          className="text-blue-600 hover:underline text-xs font-medium cursor-pointer"
        >
          Show all stocks
        </button>
      </div>

      {/* Stock Cards Container */}
      <div className="flex flex-col gap-2 max-h-[600px] overflow-y-auto pr-1">
        {isLoading && <Loading />}

        {!isLoading && stocks?.length === 0 && <p>No stocks found</p>}
        {stocks?.map((stock) => (
            <div
              key={stock.symbol}
              onClick={() => onSelectStock(stock.symbol)}
              className="bg-white border border-gray-200 rounded p-3 hover:border-blue-400 cursor-pointer transition-colors"
            >
              <div className="font-bold text-gray-900 text-xs tracking-wide">
                {stock.description}
              </div>
              <div className="text-gray-400 text-xs font-normal mt-0.5">
                ({stock.symbol})
              </div>
            </div>
          ))
        }
      </div>
    </div>
  );
};

export default StocksList;
