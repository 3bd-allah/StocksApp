import StocksHeader from "./StocksHeader";
import { useState } from "react";
import { Outlet } from "react-router"

const StocksPage = () => {
  const [ searchStocks, setSearchStocks] = useState(null);

  function handleSearchStocks(searchText){
    setSearchStocks(searchText);
  }

  

  return (
    <div className="min-h-screen bg-gray-100">
      {/* 1. Header at the top */}
      <StocksHeader onSearch={handleSearchStocks} />

      {/* 2. Responsive 2-column grid container */}
      <main >
       <Outlet context={{searchStocks, setSearchStocks}}/>
      </main>
    </div>
  );
};

export default StocksPage;
