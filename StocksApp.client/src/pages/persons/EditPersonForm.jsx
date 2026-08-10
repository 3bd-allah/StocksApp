import PersonForm from "../../components/PersonForm";
import Modal from "../../components/Modal";
import { Link, useNavigate, useParams } from "react-router";
import { useMutation, useQuery } from "@tanstack/react-query";
import { personDetailsQueryOptions } from "../../queries/personQueries";
import { updatePersonDetails } from "../../api/persons";
import { queryClient } from "../../queries/queryClient";
import ErrorBlock from "../../components/ErrorBlock";

const EditPersonForm = () => {
  const { personId } = useParams();
  const navigate = useNavigate();
  const { data: personInfo } = useQuery(personDetailsQueryOptions(personId));
  const { mutate, isPending, isError, error } = useMutation({
    mutationKey: ["editPerson"],
    mutationFn: updatePersonDetails,
    onSuccess: async () => {
      await queryClient.invalidateQueries({
        queryKey: ["persons"],
        refetchType: "none",
      });
      navigate("/persons", { replace: true });
    },
    onMutate: () => {},
  });

  function handleEditPersonInfo(personInfo) {
    const { signal } = new AbortController();
    mutate({ signal, id: personId, personDetails: personInfo });
  }
  return (
    <Modal>
      <PersonForm inputData={personInfo} onSubmit={handleEditPersonInfo}>
        {isPending && <p>Updating ....</p>}
        {!isPending && (
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
              Update
            </button>
          </>
        )}
        <br />
        {isError && (
          <ErrorBlock
            title={error.title}
            errors={error.errors}
            message={error.message}
          />
        )}
      </PersonForm>
    </Modal>
  );
};

export default EditPersonForm;
