import Navbar from "../components/Navbar";
import ErrorBlock from "../components/ErrorBlock";
import { useRouteError } from "react-router";

function RootErrorBoundary() {
  const error = useRouteError();
  console.log('error from error element',error);
  console.log(error.title)
  console.log(error.message)
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