import { Suspense } from "react";
import { Await, useLoaderData }from "react-router";


const CompanyProfile = () => {
    const {companyData} = useLoaderData();

  return (
    <Suspense fallback={<Loading />}>
        <Await resolve={companyData}>
            {(company)=>
                (
                    <>
                        <h4>
                            {company.stockName} ( <span>{company.stockSymbol}</span> )
                        </h4>
                        <p>$ {company.price}</p>
                    </>
                )
            }
        </Await>
    </Suspense>
  );
};

export default CompanyProfile;


const Loading = () => {
  return (
    <p>Loading...</p>
  )
}

async function loadCompanyProfile(){
    const response = await fetch("http://localhost:5000/company-profile")

    if(!response.ok) throw new Error("Failed to fetch data")
    
    return response.json()
}

export const loader = async () =>{

 return {
    companyData : loadCompanyProfile(),
 };
}