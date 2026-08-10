import { useQuery } from "@tanstack/react-query";
import { getAllCountries } from "../api/countries";
import ErrorBlock from "./ErrorBlock";
import Loading from "./Loading";

const CountryPicker = ({ country }) => {
  const {
    data: countries,
    isLoading,
    isError,
    error,
  } = useQuery({
    queryKey: ["countries"],
    queryFn: getAllCountries,
  });
  return (
    <>
      <label
        htmlFor="country"
        className="block text-sm font-medium text-gray-700 mb-1"
      >
        Country
      </label>

      {isLoading && <Loading />}
      {isError && (
        <ErrorBlock title="An Error Occurred" message={error?.message} />
      )}

      {countries && (
        <select
          id="country"
          name="countryId"
          required
          className="w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm bg-white focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-blue-500 text-sm"
          defaultValue={country?.countryId}
        >
          <option value="" >
            Select a country
          </option>
          {countries.map((country) => (
            <option key={country.countryId} value={country.countryId}>
              {country.countryName}
            </option>
          ))}
        </select>
      )}
    </>
  );
};

export default CountryPicker;
