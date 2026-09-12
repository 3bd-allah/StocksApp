import Navbar from "../components/Navbar";
import ErrorBlock from "../components/ErrorBlock";
import { useRouteError } from "react-router";

function RootErrorBoundary() {
  const error = useRouteError();
 
  return (
    <>
      <Navbar />
      <main className="p-6">
        <ErrorBlock
          title={error?.title}
          message={error?.message}
          errors={error?.errors ?? null}
        />
      </main>
    </>
  );
}

export default RootErrorBoundary;