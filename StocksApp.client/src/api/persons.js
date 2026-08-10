import axios from "axios";
import { personsApi } from "./configuration/axios-custom-config";
import { downloadFile } from "../utilities/downloadFile";
 
export async function fetchPersons({
  signal,
  searchBy,
  searchText,
  pageNumber,
}) {
  let api = "/persons";
  if (searchBy && searchText) {
    api += `/search?searchBy=${searchBy}&searchText=${searchText}`;
    if (pageNumber) {
      api += `&page=${pageNumber}`;
    }
  } else if (pageNumber) {
    api += `?page=${pageNumber}`;
  }

  try {
    const { data } = await axios.get(api, {
      signal: signal,
    });
    return data;
  } catch (errEx) {
    const error = new Error(errEx);
    throw error;
  }
}

export async function addPerson({ signal, personData }) {
  try {
    const { data: addedPerson } = await personsApi.post(
      "/persons",
      personData,
      {
        signal,
      },
    );
    return addedPerson;
  } catch (errEx) {
    const errorResponse = {
      title: errEx?.response?.data?.title,
      errors: Object.values(errEx?.response?.data?.errors).flat(),
    };
    throw errorResponse;
  }
}

export async function sortPersons({
  signal,
  personsToSort,
  sortBy,
  sortOptions,
}) {
  try {
    const { data: sortedPersons } = await personsApi.query(
      "/persons/sort",
      personsToSort,
      {
        signal,
        headers: {
          "Content-Type": "application/json",
        },
        params: {
          sortBy,
          sortOptions,
        },
      },
    );
    return sortedPersons;
  } catch (errEx) {
    const errorResponse = {
      title: errEx?.response?.data?.title,
      error: Object.values(errEx?.response?.data?.title).flat(),
    };
    throw errorResponse;
  }
}

export async function fetchPersonDetails({ signal, personId }) {
  try {
    const { data } = await personsApi.get(`/persons/${personId}`, { signal });
    return data;
  } catch (errEx) {
    const errorResponse = {
      title: errEx?.response?.data?.title,
      error: Object.values(errEx?.response?.data?.title).flat(),
    };
    throw errorResponse;
  }
}

export async function updatePersonDetails({ signal, id, personDetails }) {
  const personInfo = {
    personId: id,
    ...personDetails,
  };
  try {
    const { data: updatedPerson } = await personsApi.patch(
      "/persons/update",
      personInfo,
      { signal: signal },
    );
    return updatedPerson;
  } catch (errEx) {
    const errorResponse = {
      title: errEx?.response?.data?.title,
      validationErrors: Object?.values(errEx?.response?.data?.title).flat(),
      message: errEx.response.statusText,
    };
    throw errorResponse;
  }
}

export async function deletePerson({ signal, id }) {
  console.log('delete api called')
  try {
    const { data } = await personsApi.delete(`/persons/${id}`, { signal });
    return data; 
  } catch (errEx) {
    const errorResponse = {
      title: errEx?.response?.data?.title,
      validationErrors: Object?.values(errEx?.response?.data?.title).flat(),
      message: errEx.response.statusText,
    };
    throw errorResponse;
  }
}


export async function downloadPersonsPDF(){
  try{
    const {data: pdfBytes} = await personsApi.get('/persons/export-pdf', {responseType: 'blob'})
    downloadFile(pdfBytes, 'persons', 'application/pdf')
  }catch(errEx) {
    const errorResponse = {
      title: errEx?.response?.data?.title,
      validationErrors: Object?.values(errEx?.response?.data?.title).flat(),
      message: errEx.response.statusText,
    };
    throw errorResponse;
  }
}

export async function downloadPersonsReportAsCSV (){
  try{
    const {data: pdfBytes} = await personsApi.get('/persons/export-csv', {responseType: 'blob'})
    downloadFile(pdfBytes, 'persons csv report')
  }catch(errEx) {
    const errorResponse = {
      title: errEx?.response?.data?.title,
      validationErrors: Object?.values(errEx?.response?.data?.title).flat(),
      message: errEx.response.statusText,
    };
    throw errorResponse;
  }
}

export async function downloadPersonsReportAsExcel (){
  try{
    const {data: pdfBytes} = await personsApi.get('/persons/export-excel', {responseType: 'blob'})
    // return pdfBytes;
    downloadFile(pdfBytes, 'Persons_Report', "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
  }catch(errEx) {
    const errorResponse = {
      title: errEx?.response?.data?.title,
      validationErrors: Object?.values(errEx?.response?.data?.title).flat(),
      message: errEx.response.statusText,
    };
    throw errorResponse;
  }
}