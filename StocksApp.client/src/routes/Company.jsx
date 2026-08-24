/* eslint-disable react-refresh/only-export-components */
import CompanyProfile from "../pages/stocks/CompanyProfile";

const Company = () => {
  return <CompanyProfile />;
};

export default Company;

async function loadCompanyProfile() {
  const controller = new AbortController();
  const response = await fetch("http://localhost:5000/api/trade/company-profile",
    {
      signal: controller.signal
    }
  );

  if (!response.ok) throw new Error("Failed to fetch data");
  return response.json();
}

export const loader = () => {
  return {
    companyData: loadCompanyProfile(),
  };
};
