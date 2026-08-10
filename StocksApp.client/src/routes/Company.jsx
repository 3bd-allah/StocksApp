/* eslint-disable react-refresh/only-export-components */
import { useLoaderData } from "react-router";
import CompanyProfile from "../pages/company/CompanyProfile";

const Company = () => {
  const { companyData } = useLoaderData();
  console.log(companyData);
  return <CompanyProfile companyData={companyData} />;
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
