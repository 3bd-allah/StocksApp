import { Link, useNavigate } from "react-router";
import Loading from "../../components/Loading";
import { formatDateOnly } from "../../utilities/dateFormatters";
const PersonProperties = [
  { name: "Person Name", sortable: true },
  { name: "Email", sortable: true },
  { name: "Date Of Birth", sortable: false },
  { name: "Age", sortable: true },
  { name: "Gender", sortable: true },
  { name: "Country", sortable: false },
  { name: "Address", sortable: false },
  { name: "Receive News Letter", sortable: false },
];

const PersonsTable = ({
  persons,
  isLoading,
  onSorting,
  totalPages,
  onDispatch,
  currentPage,
}) => {
  const navigate = useNavigate();
  return (
    <>
      <table className="w-full border-collapse bg-white text-left text-sm text-gray-700 ">
        {/* Table Header matching the screenshot's sage-green bar */}
        <thead className="bg-[#b2d8d0] text-gray-900 font-bold">
          <tr>
            {PersonProperties.map((col) => {
              return (
                <th scope="col" className="px-4 py-3.5" key={col.name}>
                  {col.sortable ? (
                    <button
                      className="bg-transparent hover:bg-blue-500 text-blue-700 font-semibold hover:text-white py-2 px-4 border border-blue-500 hover:border-transparent rounded"
                      type="button"
                      onClick={() => onSorting(col.name)}
                    >
                      {col.name}
                    </button>
                  ) : (
                    col.name
                  )}
                </th>
              );
            })}
            <th scope="col" className="px-4 py-3.5">
              Actions
            </th>
          </tr>
        </thead>

        {isLoading && <Loading className="p-6 place-content-center" />}

        {/* Table Body with alternating row colors */}
        <tbody className="divide-y divide-gray-200">
          {persons?.length === 0 ? (
            <tr>
              <td colSpan="8" className="px-4 py-3 text-center text-gray-500">
                No persons found.
              </td>
            </tr>
          ) : (
            persons?.map((person) => {
              return (
                <tr
                  key={person.personId}
                  className="bg-gray-100 hover:bg-gray-200/70"
                >
                  <td className="px-4 py-3 text-gray-900 font-medium">
                    <button onClick={()=> navigate(person.personId)} className="bg-transparent">
                      {person.personName}
                    </button>
                  </td>
                  <td className="px-4 py-3 text-gray-600">{person.email}</td>
                  <td className="px-4 py-3 text-gray-600 whitespace-nowrap">
                    {formatDateOnly(person.dateOfBirth)}
                  </td>
                  <td className="px-4 py-3 text-gray-600">{person.age}</td>
                  <td className="px-4 py-3 text-gray-600">
                    {person.gender?.toLowerCase()}
                  </td>
                  <td className="px-4 py-3 text-gray-600">
                    {person.country?.countryName}
                  </td>
                  <td className="px-4 py-3 text-gray-600">{person.address}</td>
                  <td className="px-4 py-3 text-gray-600">
                    {person.receivedNewsLetter.toString()}
                  </td>
                  <td>
                    <Link to={`${person.personId}/edit`}>Edit</Link>
                    <br />
                    <Link to={`${person.personId}/delete`}>Delete</Link>
                  </td>
                </tr>
              );
            })
          )}
        </tbody>
      </table>
      { totalPages !== undefined && totalPages !== 0 && (
        <div className="flex gap-5 justify-center m-3">
          <button
            type="button"
            hidden={currentPage === 1}
            onClick={() => onDispatch({ type: "prev" })}
          >
            Prev
          </button>
          <button
            type="button"
            hidden={currentPage === totalPages}
            onClick={() => {
              onDispatch({ type: "next" });
            }}
          >
            Next
          </button>
        </div>
      )}
    </>
  );
};

export default PersonsTable;
