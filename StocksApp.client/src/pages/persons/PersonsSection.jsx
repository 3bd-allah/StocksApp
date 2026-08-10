import { useEffect, useReducer, useState } from "react";
import PersonsTable from "./PersonsTable";
import SearchSection from "./SearchSection";
import { fetchPersons, sortPersons } from "../../api/persons";
import { useMutation, useQuery } from "@tanstack/react-query";

function pageReducer (state, action){
  switch(action.type){
    case 'next' : return state + 1;
    case 'prev' : return state - 1;
    default : return action.payload;
  }
}


const PersonsSection = () => {

  const [searchText, setSearchText] = useState("");
  const [searchBy, setSearchBy] = useState("PersonName");
  const [sortBy, setSortBy] = useState("");
  const [sortOptions, setSortOptions] = useState(0);
  const [displayedPersons, setDisplayedPersons] = useState();
  const [pageNumber, dispatchPage ] = useReducer(pageReducer, 1);
  
  const { data , isLoading } = useQuery({
    queryKey: ["persons", { searchBy, searchText, pageNumber} ],
    queryFn: ({ signal, queryKey }) => fetchPersons({ signal, ...queryKey[1] }),
  });

  useEffect(() => {
    if (data) {
      // eslint-disable-next-line react-hooks/set-state-in-effect
      setDisplayedPersons(data.persons);
    }
  }, [data]);

  const { mutate: requestSort, isPending: isSorting } = useMutation({
    mutationKey: ["sort", { sortBy, sortOptions }],
    mutationFn: sortPersons,
    onSuccess: (fetchedSortedPersons) => {
      setDisplayedPersons(fetchedSortedPersons ?? [])
    },
  });

  const handleSearchState = ({ searchBy, searchText }) => {
    dispatchPage({payload:1})
    setSearchBy(searchBy);
    setSearchText(searchText);
  };

  const handleSortState = (colName) => {
    const nextSortOptions =
      sortBy === colName ? (sortOptions === 0 ? 1 : 0 ) : 0;

    setSortBy(colName);
    setSortOptions(nextSortOptions);

    const { signal } = new AbortController();
    
    requestSort({
      signal,
      personsToSort: displayedPersons,
      sortBy: colName,
      sortOptions: nextSortOptions,
    });
  };
  return (
    <>
      <SearchSection onSearchSubmit={handleSearchState} />
      <PersonsTable
        persons={displayedPersons}
        totalPages={data?.totalPages}
        isLoading={isLoading || isSorting}
        onSorting={handleSortState}
        onDispatch={dispatchPage}
        currentPage = {pageNumber}
      />
    </>
  );
};

export default PersonsSection;
