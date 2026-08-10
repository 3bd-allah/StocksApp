import { Outlet } from 'react-router'
import { queryClient } from "../queries/queryClient";
import { personDetailsQueryOptions } from "../queries/personQueries";
import PersonDetailsPage from '../pages/persons/PersonDetailsPage';

const PersonDetails = () => {
  return (
    <>
        <PersonDetailsPage />
        <Outlet />
    </>
  )
}

export default PersonDetails

// eslint-disable-next-line react-refresh/only-export-components
export const loader = async({params}) =>{
    const { personId } = params;
    if(!personId){
        throw new Response("Person ID required", {status:400});
    }
    
    const data = await queryClient.ensureQueryData(personDetailsQueryOptions(personId))
    return data;
} 