import React, { useRef } from "react";
import { NavLink, useLocation, useNavigate } from "react-router";

const navItems = [
  { name: "Explore", path: "explore", clickable: true },
  { name: "Trade", path: "trade", clickable: false },
  { name: "Orders", path: "orders", clickable: true },
];

const StocksHeader = ({ onSearch }) => {
  const searchStocksRef = useRef();
  const location = useLocation();
  const navigate = useNavigate();

  // Extract path segments (e.g., "/Trade/SellOrder" -> ["Trade", "SellOrder"])
  const pathSegments = location.pathname.split("/").filter(Boolean);

  function handleEnteredSearchStocks(event) {
    const enteredSymbol = searchStocksRef.current.value;

    if (!pathSegments.includes("explore")) {
      if (event.key === "Enter") {
        if(searchStocksRef.current.value?.length !== 0) {
          navigate("/stocks/explore");
          onSearch(enteredSymbol.trim());
          searchStocksRef.current.value = "";
        }
      }
    } else {
      if(enteredSymbol.length !== 0 ){
        if (event.key === "Enter") {
          onSearch(enteredSymbol.trim());
          searchStocksRef.current.value = "";
        }
      }
    }
  }

  return (
    <header className="w-full bg-gray-50 border-b border-gray-200 pt-4 pb-2 px-6 font-sans">
      {/* Top Bar */}
      <div className="flex justify-between items-center mb-4">
        {/* Logo Section */}
        <div className="flex items-center gap-2">
          <svg
            className="w-7 h-7 text-black"
            viewBox="0 0 24 24"
            fill="currentColor"
          >
            <path d="M16 6l2.29 2.29-4.88 4.88-4-4L2 16.59 3.41 18l6-6 4 4 6.3-6.29L22 12V6h-6z" />
            <path d="M19 18H5v-2h14v2z" />
          </svg>
          <h1 className="text-2xl font-bold text-gray-900 tracking-tight">
            Stocks
          </h1>
        </div>

        {/* Right Section: Search, Settings, Login */}
        <div className="flex items-center gap-4">
          <input
            ref={searchStocksRef}
            required
            type="text"
            placeholder="Search Stocks"
            className="w-56 px-4 py-1.5 text-sm bg-white border border-gray-300 rounded-full focus:outline-none focus:ring-2 focus:ring-blue-500 placeholder-gray-400"
            onKeyDown={handleEnteredSearchStocks}
          />
          <button
            className="text-gray-700 hover:text-black transition-colors"
            aria-label="Settings"
          >
            <svg className="w-5 h-5" fill="currentColor" viewBox="0 0 20 20">
              <path
                fillRule="evenodd"
                d="M11.49 3.17c-.38-1.56-2.6-1.56-2.98 0a1.532 1.532 0 01-2.286.948c-1.372-.836-2.942.734-2.106 2.106.54.886.061 2.042-.947 2.287-1.561.379-1.561 2.6 0 2.978a1.532 1.532 0 01.947 2.287c-.836 1.372.734 2.942 2.106 2.106a1.532 1.532 0 012.287.947c.379 1.561 2.6 1.561 2.978 0a1.532 1.532 0 012.287-.947c1.372.836 2.942-.734 2.106-2.106a1.532 1.532 0 01.947-2.287c1.561-.379 1.561-2.6 0-2.978a1.532 1.532 0 01-.947-2.287c.836-1.372-.734-2.942-2.106-2.106a1.532 1.532 0 01-2.287-.947zM10 13a3 3 0 100-6 3 3 0 000 6z"
                clipRule="evenodd"
              />
            </svg>
          </button>
          <button className="bg-blue-600 hover:bg-blue-700 text-white font-medium text-sm px-4 py-1.5 rounded transition-colors">
            Login
          </button>
        </div>
      </div>

      {/* Navigation Tabs */}
      <nav className="flex gap-6 border-b border-gray-200">
        {navItems.map((item) => (
          <button
            key={item.name}
            className={`pb-2 text-sm font-medium transition-colors relative ${item.clickable ? "cursor-pointer" : "cursor-not-allowed"}`}
          >
            <NavLink
              key={item.name}
              to={item.path}
              aria-disabled={!item.clickable}
              onClick={(e) => {
                if (!item.clickable) e.preventDefault(); // Explicitly stops React Router transition
              }}
              className={({ isActive }) =>
                `pb-2 text-sm font-medium transition-colors relative ${
                  isActive
                    ? "text-blue-600 font-semibold border-b-2 border-blue-600"
                    : "text-blue-500 hover:text-blue-700"
                }
              ${item.clickable ? "cursor-pointer" : "cursor-not-allowed"}`
              }
            >
              {item.name}
            </NavLink>
          </button>
        ))}
      </nav>

      {/* Breadcrumbs Section */}
      <div className="flex items-center gap-1.5 mt-3 text-xs text-gray-500 font-medium">
        {pathSegments.map((segment, index) => (
          <React.Fragment key={index}>
            <span>▶</span>
              <span
                className={
                  index === pathSegments.length - 1
                    ? "text-gray-700 font-semibold"
                    : ""
                }
              >
                {segment}
              </span>
          </React.Fragment>
        ))}
      </div>
    </header>
  );
};

export default StocksHeader;
