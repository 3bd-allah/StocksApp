import { useRef } from "react";


const SearchSection = ({ onSearchSubmit }) => {
  const searchByRef = useRef();
  const searchTextRef = useRef();

  const handleSearchClick = () => {
    onSearchSubmit({
      searchBy: searchByRef.current.value,
      searchText: searchTextRef.current.value,
    });
  };
  return (
    <div className="p-4 bg-gray-100 rounded-lg flex flex-col sm:flex-row gap-3 items-center">
      {/* 1. Dropdown Select */}
      <p> Filter By</p>
      <select
        className="w-full sm:w-48 p-2 border border-gray-300 rounded bg-white text-gray-700 text-sm focus:outline-none focus:border-blue-500"
        defaultValue={"PersonName"}
        ref={searchByRef}
      >
        <option value={"PersonName"}>Person Name</option>
        <option value={"Email"}>Email</option>
        <option value={"Country"}>Country</option>
        <option value={"Address"}>Address</option>
        <option value={"Gender"}>Gender</option>
      </select>

      {/* 2. Text Input */}
      <input
        ref={searchTextRef}
        type="text"
        placeholder="Search..."
        // value={searchText}
        className="w-full flex-1 p-2 border border-gray-300 rounded text-sm focus:outline-none focus:border-blue-500"
      />

      {/* 3. Search Button & Clear Link */}
      <div className="flex items-center gap-3 w-full sm:w-auto justify-end">
        <button
          className="bg-blue-600 hover:bg-blue-700 text-white px-4 py-2 rounded text-sm font-medium transition-colors"
          onClick={handleSearchClick}
        >
          Search
        </button>

        <button
          onClick={() => (searchTextRef.current.value = "")}
          className="text-sm text-gray-500 hover:text-red-500 underline"
        >
          Clear all
        </button>
      </div>
    </div>
  );
};

export default SearchSection;
