import CountryPicker from "./CountryPicker";
import { formatDateOnly } from "../utilities/helperFunctions";

const PersonForm = ({ inputData, onSubmit, children }) => {

  const handleSubmit = (event) => {
    event.preventDefault();

    const formData = new FormData(event.target);
    const data = Object.fromEntries(formData);
    const subscribeToNewsLetter = data.receivedNewsLetter;
  
    // TODO: handle (onSubmit) prop HERE:
    const newPerson = {
      ...data,
      receivedNewsLetter: subscribeToNewsLetter == "on" ? true : false,
    }
    onSubmit(newPerson);
  };
  return (
    <div className="max-w-md mx-auto mt-10 p-5 bg-white rounded-xl shadow-md border border-gray-100">
      <h2 className="text-2xl font-bold text-gray-800 mb-5">
        Personal Information
      </h2>

      <form className="space-y-5" onSubmit={handleSubmit}>
        <div>
          <label
            htmlFor="personName"
            className="block text-sm font-medium text-gray-700 mb-1"
          >
            Full Name
          </label>
          <input
            type="text"
            id="personName"
            name="personName"
            required
            className="w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-blue-500 text-sm"
            defaultValue={inputData?.personName ?? ""}
          />
        </div>

        <div>
          <label
            htmlFor="email"
            className="block text-sm font-medium text-gray-700 mb-1"
          >
            Email Address
          </label>
          <input
            type="email"
            id="email"
            name="email"
            required
            className="w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-blue-500 text-sm"
            defaultValue={inputData?.email ?? ""}
          />
        </div>

        <div>
          <label
            htmlFor="dateOfBirth"
            className="block text-sm font-medium text-gray-700 mb-1"
          >
            Date of Birth
          </label>
          <input
            type="date"
            id="dateOfBirth"
            name="dateOfBirth"
            required
            className="w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-blue-500 text-sm"
            defaultValue={formatDateOnly(inputData?.dateOfBirth)}
          />
        </div>

        <div>
          <span className="block text-sm font-medium text-gray-700 mb-2">
            Gender
          </span>
          <div className="flex items-center space-x-6">
            <label className="flex items-center text-sm text-gray-600 cursor-pointer">
              <input
                type="radio"
                name="gender"
                value= "male"
                defaultChecked={inputData?.gender?.toLowerCase() === 'male'}
                className="h-4 w-4 text-blue-600 focus:ring-blue-500 border-gray-300"
              />
              <span className="ml-2">Male</span>
            </label>
            <label className="flex items-center text-sm text-gray-600 cursor-pointer">
              <input
                type="radio"
                name="gender"
                value="female"
                defaultChecked={inputData?.gender?.toLowerCase() === 'female'}
                className="h-4 w-4 text-blue-600 focus:ring-blue-500 border-gray-300"
              />
              <span className="ml-2">Female</span>
            </label>
          </div>
        </div>

        <div>
          <CountryPicker country={inputData?.country}/>
        </div>

        <div>
          <label
            htmlFor="address"
            className="block text-sm font-medium text-gray-700 mb-1"
          >
            Address
          </label>
          <textarea
            id="address"
            name="address"
            rows="3"
            required
            className="w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-blue-500 text-sm"
            placeholder="Street, Apartment, City, State"
            defaultValue={inputData?.address}
          ></textarea>
        </div>

        <div className="flex items-start">
          <div className="flex items-center h-5">
            <input
              id="receivedNewsLetter"
              name="receivedNewsLetter"
              type="checkbox"
              className="h-4 w-4 text-blue-600 focus:ring-blue-500 border-gray-300 rounded"
              defaultChecked={inputData?.receivedNewsLetter}
            />
          </div>
          <div className="ml-3 text-sm">
            <label
              htmlFor="receivedNewsLetter"
              className="font-medium text-gray-700 cursor-pointer"
            >
              Subscribe to newsletter
            </label>
            <p className="text-gray-500">
              Get the latest updates and news delivered to your inbox.
            </p>
          </div>
        </div>

        <div className="flex p-2 gap-2">{children}</div>
      </form>
    </div>
  );
};

export default PersonForm;
