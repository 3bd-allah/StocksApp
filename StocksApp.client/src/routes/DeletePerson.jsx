import { useNavigate, useParams } from "react-router"
import DeletePersonModal from "../pages/persons/DeletePersonModal"
import { useMutation, useQuery } from "@tanstack/react-query"
import { personDetailsQueryOptions } from "../queries/personQueries"
import { deletePerson } from "../api/persons"
import { useCallback } from "react"
import toast from "react-hot-toast"
import { queryClient } from "../queries/queryClient"
const DeletePerson = () => {
  const params = useParams()
  const navigate = useNavigate();
  const { data: personDetails }= useQuery(personDetailsQueryOptions(params.personId))
  
  const { mutate } = useMutation({
    mutationFn: deletePerson,
    onSuccess:async ()=>{
      await queryClient.invalidateQueries({queryKey:['persons'] , refetchType:"none"})
      navigate('/persons')
      toast.success(`${personDetails.personName} is Deleted successfully`)
    },
    onError:()=>{
      toast.error('something went wrong')
    }
  })

  const confirmDeletion = useCallback(()=>{
    const {signal} = new AbortController();
    mutate({signal, id: params.personId})
  },[params.personId, mutate])


  return (
    <DeletePersonModal person={personDetails} onDelete={confirmDeletion} />
  )
}

export default DeletePerson;