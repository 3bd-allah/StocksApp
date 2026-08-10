/* eslint-disable react-refresh/only-export-components */
import PersonsPage from "../pages/persons/PersonsPage";
import axios from "axios";

const Persons = () => {

  return(
    <PersonsPage  />
    );
};

export default Persons;

async function loadPersons() {
  try {
    const { data } = await axios.get("/persons");
    // if (!response.ok) {
    //   throw new Error("Failed to fetch data");
    // }

    return data;
  } catch (error) {
    throw new Error("Failed to fetch data", { cause: error });
  }
}

export const loader = async () => {
  return {
    personsPromise: loadPersons(),
  };
};
