import { queryOptions } from "@tanstack/react-query";
import { fetchPersonDetails } from "../api/persons";

export const personDetailsQueryOptions = (personId)=>{
    return queryOptions({
        queryKey:['persons', { personId }],
        queryFn: ({signal, queryKey}) => fetchPersonDetails({signal, ...queryKey[1]})
    })
}