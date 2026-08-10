import { Suspense } from "react";
import { Await } from "react-router";
import Loading from "../../components/Loading.jsx";

const CompanyProfile = ({ companyData }) => {
  return (
    <Suspense fallback={<Loading className="place-content-center" />}>
      <Await resolve={companyData}>
        {(company) => (
          <>
            <h4>
              {company.stockName} ( <span>{company.stockSymbol}</span> )
            </h4>
            <p>$ {company.price}</p>
          </>
        )}
      </Await>
    </Suspense>
  );
};

export default CompanyProfile;
