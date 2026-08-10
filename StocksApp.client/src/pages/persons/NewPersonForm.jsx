import { useMutation } from "@tanstack/react-query";
import Modal from "../../components/Modal";
import PersonForm from "../../components/PersonForm";
import { Link, useNavigate } from "react-router";
import { addPerson } from "../../api/persons";
import Loading from "../../components/Loading";
import ErrorBlock from "../../components/ErrorBlock";
import { queryClient } from "../../queries/queryClient";

const NewPersonForm = () => {
  const navigate = useNavigate();

  const { mutate, isPending, isError, error } = useMutation({
    mutationKey: ["addPerson"],
    mutationFn: addPerson,
    onSuccess: ()=>{
      queryClient.invalidateQueries({queryKey:['persons'],
        refetchType:"none"
      })
      navigate('/persons')
    }
  });

  function handleSubmit(formData) {
    console.log(formData);
    mutate({personData : formData});
  }

  return (
    <Modal>
      <PersonForm onSubmit={handleSubmit}>
        {isPending ? (
          <Loading />
        ) : (
          <>
            <Link
              to={-1}
              className="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-blue-600 hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500 transition duration-150 ease-in-out"
            >
              Cancel
            </Link>
            <button
              type="submit"
              className="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-blue-600 hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500 transition duration-150 ease-in-out"
            >
              Save Profile
            </button>
          </>
        )}
      </PersonForm>
      {isError && <ErrorBlock title={error.title} message={error.message} errors={error.errors}/>}
    </Modal>
  );
};

export default NewPersonForm;
