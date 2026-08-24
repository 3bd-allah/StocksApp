import StocksList from "./StocksList";
import SelectedStockView from "./SelectedStockView";
import { useQuery } from "@tanstack/react-query";
import { useState } from "react";
import { getAllStocks, getCompanyProfile } from "../../api/stocks";
import { useOutletContext } from "react-router";
import Loading from "../../components/Loading";

const StocksExplore = () => {
  // hooks
  const [selectedStock, setSelectedStock] = useState(null);
  const { searchStocks, setSearchStocks } = useOutletContext();

  // queries
  const {
    data: exploreStocks,
    isLoading: isLoadingExploreStocks,
    refetch,
  } = useQuery({
    queryKey: ["stocks", { searchStocks }],
    queryFn: ({ signal }) =>
      getAllStocks({
        signal,
        searchSymbol: searchStocks,
      }),
  });

  const { data: companyProfile, isLoading: isLoadingCompanyProfile } = useQuery(
    {
      queryKey: ["company-profile", selectedStock],
      queryFn: ({ signal, queryKey }) =>
        getCompanyProfile({ signal, companySymbol: queryKey[1] }),
      enabled: selectedStock !== null,
      retry: false,
    },
  );

  function handleSelectedStock(stockSymbol) {
    setSelectedStock(stockSymbol);
    setSearchStocks(null);
  }

  function handleRefetchAllExploreStocks() {
    setSearchStocks(null);
    refetch();
  }

  return (
    <div className="max-w-7xl mx-auto p-6 grid grid-cols-1 md:grid-cols-2 gap-6">
      {/* Left Half: Stock List */}
      <section className="w-full">
        <StocksList
          onSelectStock={(symbol) => handleSelectedStock(symbol)}
          stocks={exploreStocks}
          isLoading={isLoadingExploreStocks}
          onRefetch={handleRefetchAllExploreStocks}
        />
      </section>

      {/* Right Half: Main Detail Section (e.g., CompanyProfile component) */}
      <section className="w-full">
        {/* CompanyProfile or detail view goes here */}
        {!selectedStock && <p>Click a Stock on the left to see details.</p>}
        {isLoadingCompanyProfile && <Loading />}
        {companyProfile && <SelectedStockView stock={companyProfile} />}
      </section>
    </div>
  );
};

export default StocksExplore;
